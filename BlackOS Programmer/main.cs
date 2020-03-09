using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Diagnostics;

namespace BlackOS_Programmer
{
    public partial class main : Form
    {
        int x, y, w, h;

        string com_port;

        int total_bytes;
        int current_bytes;

        byte[] program;

        public main()
        {
            InitializeComponent();

            // Set variables for drawing loading bar border
            x = loading_bar.Left;
            y = loading_bar.Top;
            w = loading_bar.Width;
            h = loading_bar.Height;

            loading_bar.Width = 0;
            loading_label.Visible = false;

            file_path_text_box.Text = Properties.Settings.Default.file_name;
        }

        private void browse_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();

            if (file.ShowDialog() == DialogResult.OK)
            {
                file_path_text_box.Text = file.FileName;
                Properties.Settings.Default.file_name = file.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void com_port_box_DropDown(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();

            com_port_box.Items.Clear();
            com_port_box.Items.AddRange(ports);
        }

        private void com_port_box_TextChanged(object sender, EventArgs e)
        {
            com_port = com_port_box.Text;
        }

        private void open_connection()
        {
            try
            {
                serial_port.PortName = com_port;
                serial_port.DataBits = 8;
                serial_port.BaudRate = 115200;
                serial_port.StopBits = StopBits.One;
                serial_port.Parity = Parity.None;

                serial_port.Open();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void close_connection()
        {
            if (serial_port.IsOpen)
            {
                serial_port.Close();
            }
        }

        private void program_button_Click(object sender, EventArgs e)
        {
            open_connection();
            show_loading_screen();

            if (serial_port.IsOpen)
            {
                program = File.ReadAllBytes(Properties.Settings.Default.file_name);
                
                

                total_bytes = program.Length;

                serial_port.Write("P");

                byte[] bytes = BitConverter.GetBytes(total_bytes);
                if (BitConverter.IsLittleEndian == false)
                    Array.Reverse(bytes);

                for (int i = 0; i< 4; i++)
                {
                    serial_port.Write(bytes, i, 1);
                    Wait(10000);
                }

                this.Update();

                for (int i = 0; i < 4; i++)
                {
                    serial_port.Write(program, i, 1);
                    Wait(10000);
                }

                for (int i = 0; i < total_bytes; i++)
                {
                    serial_port.Write(program, i, 1);
                    Wait(1000);
                    current_bytes++;
                    update_loading();
                }

                serial_port.Write("P");

                loading_label.Text = "SUCCESS";
                this.Update();

                timer.Start();
            }

            close_connection();
        }

        const long microsecondsPerSecond = 1000000;

        static void Wait(long waitMicroseconds)
        {
            long waitTicks = (waitMicroseconds * Stopwatch.Frequency) / microsecondsPerSecond;

            Stopwatch sw = new Stopwatch();
            sw.Start();
            while (sw.ElapsedTicks <= waitTicks) ;
        }

        private void update_loading()
        {
            int new_w = Convert.ToInt32(current_bytes * w / total_bytes);

            loading_bar.Width = new_w;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            hide_loading_screen();
        }

        private void show_loading_screen()
        {
            com_port_box.Visible = false;
            file_path_text_box.Visible = false;
            browse_button.Visible = false;
            program_button.Visible = false;

            loading_label.Visible = true;
            loading_bar.Visible = true;
            loading_label.Text = "DOWNLOADING...";
            loading_label.ForeColor = Color.Lime;

            loading_bar.Width = 0;
            total_bytes = 0;
            current_bytes = 0;
            loading_bar.BackColor = Color.Lime;

            Graphics g = this.CreateGraphics();
            Pen selPen = new Pen(Color.Lime);
            g.DrawRectangle(selPen, x - 2, y - 2, w + 3, h + 3);
            g.Dispose();
        }

        private void hide_loading_screen()
        {
            loading_label.Visible = false;
            loading_bar.Width = 0;

            Graphics g = this.CreateGraphics();
            Pen selPen = new Pen(Color.FromArgb(20, 20, 20));
            g.DrawRectangle(selPen, x - 2, y - 2, w + 3, h + 3);
            g.Dispose();

            com_port_box.Visible = true;
            file_path_text_box.Visible = true;
            browse_button.Visible = true;
            program_button.Visible = true;
        }

        private void loading_error()
        {
            loading_label.Visible = true;
            loading_label.Text = "ERROR";
            loading_label.ForeColor = Color.Red;

            loading_bar.BackColor = Color.Red;

            Graphics g = this.CreateGraphics();
            Pen selPen = new Pen(Color.Red);
            g.DrawRectangle(selPen, x - 2, y - 2, w + 3, h + 3);
            g.Dispose();
        }
    }
}
