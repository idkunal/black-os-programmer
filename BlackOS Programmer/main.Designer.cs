namespace BlackOS_Programmer
{
    partial class main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.program_button = new System.Windows.Forms.Button();
            this.browse_button = new System.Windows.Forms.Button();
            this.file_path_text_box = new System.Windows.Forms.TextBox();
            this.com_port_box = new System.Windows.Forms.ComboBox();
            this.serial_port = new System.IO.Ports.SerialPort(this.components);
            this.loading_bar = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.loading_label = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // program_button
            // 
            this.program_button.Location = new System.Drawing.Point(381, 39);
            this.program_button.Name = "program_button";
            this.program_button.Size = new System.Drawing.Size(75, 64);
            this.program_button.TabIndex = 10;
            this.program_button.Text = "Program";
            this.program_button.UseVisualStyleBackColor = true;
            this.program_button.Click += new System.EventHandler(this.program_button_Click);
            // 
            // browse_button
            // 
            this.browse_button.Location = new System.Drawing.Point(381, 10);
            this.browse_button.Name = "browse_button";
            this.browse_button.Size = new System.Drawing.Size(75, 23);
            this.browse_button.TabIndex = 9;
            this.browse_button.Text = "Browse";
            this.browse_button.UseVisualStyleBackColor = true;
            this.browse_button.Click += new System.EventHandler(this.browse_button_Click);
            // 
            // file_path_text_box
            // 
            this.file_path_text_box.Location = new System.Drawing.Point(12, 12);
            this.file_path_text_box.Name = "file_path_text_box";
            this.file_path_text_box.Size = new System.Drawing.Size(363, 20);
            this.file_path_text_box.TabIndex = 8;
            // 
            // com_port_box
            // 
            this.com_port_box.FormattingEnabled = true;
            this.com_port_box.Location = new System.Drawing.Point(12, 38);
            this.com_port_box.Name = "com_port_box";
            this.com_port_box.Size = new System.Drawing.Size(75, 21);
            this.com_port_box.TabIndex = 6;
            this.com_port_box.DropDown += new System.EventHandler(this.com_port_box_DropDown);
            this.com_port_box.TextChanged += new System.EventHandler(this.com_port_box_TextChanged);
            // 
            // loading_bar
            // 
            this.loading_bar.BackColor = System.Drawing.Color.Lime;
            this.loading_bar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.loading_bar.Location = new System.Drawing.Point(53, 51);
            this.loading_bar.Name = "loading_bar";
            this.loading_bar.Size = new System.Drawing.Size(353, 27);
            this.loading_bar.TabIndex = 11;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // loading_label
            // 
            this.loading_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.loading_label.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loading_label.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loading_label.ForeColor = System.Drawing.Color.Lime;
            this.loading_label.Location = new System.Drawing.Point(144, 25);
            this.loading_label.Multiline = true;
            this.loading_label.Name = "loading_label";
            this.loading_label.Size = new System.Drawing.Size(175, 20);
            this.loading_label.TabIndex = 0;
            this.loading_label.Text = "DOWNLOAD";
            this.loading_label.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(472, 118);
            this.Controls.Add(this.loading_label);
            this.Controls.Add(this.loading_bar);
            this.Controls.Add(this.program_button);
            this.Controls.Add(this.browse_button);
            this.Controls.Add(this.file_path_text_box);
            this.Controls.Add(this.com_port_box);
            this.Name = "main";
            this.Text = "BlackOS Programmer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button program_button;
        private System.Windows.Forms.Button browse_button;
        private System.Windows.Forms.TextBox file_path_text_box;
        private System.Windows.Forms.ComboBox com_port_box;
        private System.IO.Ports.SerialPort serial_port;
        private System.Windows.Forms.Panel loading_bar;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox loading_label;
    }
}

