namespace sshtest
{
    partial class Form1
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
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.textBox_HostName = new System.Windows.Forms.TextBox();
            this.textBox_Command = new System.Windows.Forms.TextBox();
            this.textBox_Output = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Run = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Keyfile = new System.Windows.Forms.TextBox();
            this.button_keyBrowse = new System.Windows.Forms.Button();
            this.textBox_MacAddr = new System.Windows.Forms.TextBox();
            this.label_mactoip_ms = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Username
            // 
            this.textBox_Username.Location = new System.Drawing.Point(51, 39);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(100, 20);
            this.textBox_Username.TabIndex = 0;
            this.textBox_Username.Text = "support";
            // 
            // textBox_HostName
            // 
            this.textBox_HostName.Location = new System.Drawing.Point(208, 12);
            this.textBox_HostName.Name = "textBox_HostName";
            this.textBox_HostName.Size = new System.Drawing.Size(100, 20);
            this.textBox_HostName.TabIndex = 1;
            // 
            // textBox_Command
            // 
            this.textBox_Command.Location = new System.Drawing.Point(51, 63);
            this.textBox_Command.Name = "textBox_Command";
            this.textBox_Command.Size = new System.Drawing.Size(437, 20);
            this.textBox_Command.TabIndex = 2;
            this.textBox_Command.Text = "ls -la";
            // 
            // textBox_Output
            // 
            this.textBox_Output.Location = new System.Drawing.Point(12, 90);
            this.textBox_Output.Multiline = true;
            this.textBox_Output.Name = "textBox_Output";
            this.textBox_Output.ReadOnly = true;
            this.textBox_Output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Output.Size = new System.Drawing.Size(534, 181);
            this.textBox_Output.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Host:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "User:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cmd:";
            // 
            // button_Run
            // 
            this.button_Run.Location = new System.Drawing.Point(495, 64);
            this.button_Run.Name = "button_Run";
            this.button_Run.Size = new System.Drawing.Size(51, 23);
            this.button_Run.TabIndex = 7;
            this.button_Run.Text = "&Run";
            this.button_Run.UseVisualStyleBackColor = true;
            this.button_Run.Click += new System.EventHandler(this.button_Run_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "KeyFile:";
            // 
            // textBox_Keyfile
            // 
            this.textBox_Keyfile.Location = new System.Drawing.Point(208, 39);
            this.textBox_Keyfile.Name = "textBox_Keyfile";
            this.textBox_Keyfile.Size = new System.Drawing.Size(280, 20);
            this.textBox_Keyfile.TabIndex = 9;
            this.textBox_Keyfile.Text = "C:\\Users\\victormartin\\openssh.key";
            // 
            // button_keyBrowse
            // 
            this.button_keyBrowse.Location = new System.Drawing.Point(495, 35);
            this.button_keyBrowse.Name = "button_keyBrowse";
            this.button_keyBrowse.Size = new System.Drawing.Size(51, 23);
            this.button_keyBrowse.TabIndex = 10;
            this.button_keyBrowse.Text = "&Browse";
            this.button_keyBrowse.UseVisualStyleBackColor = true;
            this.button_keyBrowse.Click += new System.EventHandler(this.button_keyBrowse_Click);
            // 
            // textBox_MacAddr
            // 
            this.textBox_MacAddr.Location = new System.Drawing.Point(51, 15);
            this.textBox_MacAddr.Name = "textBox_MacAddr";
            this.textBox_MacAddr.Size = new System.Drawing.Size(100, 20);
            this.textBox_MacAddr.TabIndex = 11;
            this.textBox_MacAddr.Text = "78-a5-04-9c-fa-df";
            // 
            // label_mactoip_ms
            // 
            this.label_mactoip_ms.AutoSize = true;
            this.label_mactoip_ms.Location = new System.Drawing.Point(314, 15);
            this.label_mactoip_ms.Name = "label_mactoip_ms";
            this.label_mactoip_ms.Size = new System.Drawing.Size(35, 13);
            this.label_mactoip_ms.TabIndex = 12;
            this.label_mactoip_ms.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 408);
            this.Controls.Add(this.label_mactoip_ms);
            this.Controls.Add(this.textBox_MacAddr);
            this.Controls.Add(this.button_keyBrowse);
            this.Controls.Add(this.textBox_Keyfile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_Run);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Output);
            this.Controls.Add(this.textBox_Command);
            this.Controls.Add(this.textBox_HostName);
            this.Controls.Add(this.textBox_Username);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.TextBox textBox_HostName;
        private System.Windows.Forms.TextBox textBox_Command;
        private System.Windows.Forms.TextBox textBox_Output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Run;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Keyfile;
        private System.Windows.Forms.Button button_keyBrowse;
        private System.Windows.Forms.TextBox textBox_MacAddr;
        private System.Windows.Forms.Label label_mactoip_ms;
    }
}

