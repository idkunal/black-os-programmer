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
            this.loading_bar = new System.Windows.Forms.Panel();
            this.program_button = new System.Windows.Forms.Button();
            this.browse_button = new System.Windows.Forms.Button();
            this.file_path_text_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.com_port_box = new System.Windows.Forms.ComboBox();
            this.serial_port = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // loading_bar
            // 
            this.loading_bar.BackColor = System.Drawing.Color.SpringGreen;
            this.loading_bar.Location = new System.Drawing.Point(12, 109);
            this.loading_bar.Name = "loading_bar";
            this.loading_bar.Size = new System.Drawing.Size(202, 17);
            this.loading_bar.TabIndex = 11;
            // 
            // program_button
            // 
            this.program_button.Location = new System.Drawing.Point(139, 36);
            this.program_button.Name = "program_button";
            this.program_button.Size = new System.Drawing.Size(75, 23);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "COM Port";
            // 
            // com_port_box
            // 
            this.com_port_box.FormattingEnabled = true;
            this.com_port_box.Location = new System.Drawing.Point(12, 38);
            this.com_port_box.Name = "com_port_box";
            this.com_port_box.Size = new System.Drawing.Size(121, 21);
            this.com_port_box.TabIndex = 6;
            this.com_port_box.DropDown += new System.EventHandler(this.com_port_box_DropDown);
            this.com_port_box.TextChanged += new System.EventHandler(this.com_port_box_TextChanged);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 141);
            this.Controls.Add(this.loading_bar);
            this.Controls.Add(this.program_button);
            this.Controls.Add(this.browse_button);
            this.Controls.Add(this.file_path_text_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.com_port_box);
            this.Name = "main";
            this.Text = "BlackOS Programmer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel loading_bar;
        private System.Windows.Forms.Button program_button;
        private System.Windows.Forms.Button browse_button;
        private System.Windows.Forms.TextBox file_path_text_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox com_port_box;
        private System.IO.Ports.SerialPort serial_port;
    }
}

