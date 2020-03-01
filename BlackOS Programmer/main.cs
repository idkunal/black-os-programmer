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

namespace BlackOS_Programmer
{
    public partial class main : Form
    {
        string com_port;

        public main()
        {
            InitializeComponent();
        }

        private void browse_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();

            if (file.ShowDialog() == DialogResult.OK)
            {
                file_path_text_box.Text = file.FileName;
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



            close_connection();
        }
    }
}
