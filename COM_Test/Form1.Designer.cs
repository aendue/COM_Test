namespace COM_Test
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_send = new System.Windows.Forms.Button();
            this.text = new System.Windows.Forms.TextBox();
            this.cb_port = new System.Windows.Forms.ComboBox();
            this.tb_port = new System.Windows.Forms.Label();
            this.bt_test = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(100, 25);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(90, 52);
            this.btn_send.TabIndex = 0;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.button1_Click);
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(64, 99);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(165, 20);
            this.text.TabIndex = 1;
            // 
            // cb_port
            // 
            this.cb_port.FormattingEnabled = true;
            this.cb_port.Location = new System.Drawing.Point(100, 179);
            this.cb_port.Name = "cb_port";
            this.cb_port.Size = new System.Drawing.Size(121, 21);
            this.cb_port.TabIndex = 2;
            // 
            // tb_port
            // 
            this.tb_port.AutoSize = true;
            this.tb_port.Location = new System.Drawing.Point(51, 187);
            this.tb_port.Name = "tb_port";
            this.tb_port.Size = new System.Drawing.Size(37, 13);
            this.tb_port.TabIndex = 3;
            this.tb_port.Text = "PORT";
            // 
            // bt_test
            // 
            this.bt_test.Location = new System.Drawing.Point(29, 230);
            this.bt_test.Name = "bt_test";
            this.bt_test.Size = new System.Drawing.Size(86, 27);
            this.bt_test.TabIndex = 4;
            this.bt_test.Text = "Test";
            this.bt_test.UseVisualStyleBackColor = true;
            this.bt_test.Click += new System.EventHandler(this.bt_test_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.bt_test);
            this.Controls.Add(this.tb_port);
            this.Controls.Add(this.cb_port);
            this.Controls.Add(this.text);
            this.Controls.Add(this.btn_send);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.ComboBox cb_port;
        private System.Windows.Forms.Label tb_port;
        private System.Windows.Forms.Button bt_test;
    }
}

