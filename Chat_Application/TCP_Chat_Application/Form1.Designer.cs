namespace TCP_Chat_Application
{
    partial class frmChatApp
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
            this.gpClient1 = new System.Windows.Forms.GroupBox();
            this.lblClient1Port = new System.Windows.Forms.Label();
            this.lblClient1IP = new System.Windows.Forms.Label();
            this.txtLocalPort = new System.Windows.Forms.TextBox();
            this.txtLocalIP = new System.Windows.Forms.TextBox();
            this.gpClient2 = new System.Windows.Forms.GroupBox();
            this.lblClient2Port = new System.Windows.Forms.Label();
            this.lblClient2IP = new System.Windows.Forms.Label();
            this.txtRemotePort = new System.Windows.Forms.TextBox();
            this.txtRemoteIP = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lstMessage = new System.Windows.Forms.ListBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtChatName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpClient1.SuspendLayout();
            this.gpClient2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpClient1
            // 
            this.gpClient1.Controls.Add(this.lblClient1Port);
            this.gpClient1.Controls.Add(this.lblClient1IP);
            this.gpClient1.Controls.Add(this.txtLocalPort);
            this.gpClient1.Controls.Add(this.txtLocalIP);
            this.gpClient1.Location = new System.Drawing.Point(51, 56);
            this.gpClient1.Name = "gpClient1";
            this.gpClient1.Size = new System.Drawing.Size(270, 126);
            this.gpClient1.TabIndex = 0;
            this.gpClient1.TabStop = false;
            this.gpClient1.Text = "Local";
            // 
            // lblClient1Port
            // 
            this.lblClient1Port.AutoSize = true;
            this.lblClient1Port.Location = new System.Drawing.Point(6, 57);
            this.lblClient1Port.Name = "lblClient1Port";
            this.lblClient1Port.Size = new System.Drawing.Size(34, 17);
            this.lblClient1Port.TabIndex = 1;
            this.lblClient1Port.Text = "Port";
            // 
            // lblClient1IP
            // 
            this.lblClient1IP.AutoSize = true;
            this.lblClient1IP.Location = new System.Drawing.Point(6, 26);
            this.lblClient1IP.Name = "lblClient1IP";
            this.lblClient1IP.Size = new System.Drawing.Size(20, 17);
            this.lblClient1IP.TabIndex = 1;
            this.lblClient1IP.Text = "IP";
            // 
            // txtLocalPort
            // 
            this.txtLocalPort.Location = new System.Drawing.Point(97, 51);
            this.txtLocalPort.Name = "txtLocalPort";
            this.txtLocalPort.Size = new System.Drawing.Size(167, 22);
            this.txtLocalPort.TabIndex = 1;
            // 
            // txtLocalIP
            // 
            this.txtLocalIP.Location = new System.Drawing.Point(97, 21);
            this.txtLocalIP.Name = "txtLocalIP";
            this.txtLocalIP.Size = new System.Drawing.Size(167, 22);
            this.txtLocalIP.TabIndex = 0;
            // 
            // gpClient2
            // 
            this.gpClient2.Controls.Add(this.lblClient2Port);
            this.gpClient2.Controls.Add(this.lblClient2IP);
            this.gpClient2.Controls.Add(this.txtRemotePort);
            this.gpClient2.Controls.Add(this.txtRemoteIP);
            this.gpClient2.Location = new System.Drawing.Point(353, 56);
            this.gpClient2.Name = "gpClient2";
            this.gpClient2.Size = new System.Drawing.Size(270, 126);
            this.gpClient2.TabIndex = 0;
            this.gpClient2.TabStop = false;
            this.gpClient2.Text = "Remote";
            // 
            // lblClient2Port
            // 
            this.lblClient2Port.AutoSize = true;
            this.lblClient2Port.Location = new System.Drawing.Point(6, 54);
            this.lblClient2Port.Name = "lblClient2Port";
            this.lblClient2Port.Size = new System.Drawing.Size(34, 17);
            this.lblClient2Port.TabIndex = 1;
            this.lblClient2Port.Text = "Port";
            // 
            // lblClient2IP
            // 
            this.lblClient2IP.AutoSize = true;
            this.lblClient2IP.Location = new System.Drawing.Point(6, 27);
            this.lblClient2IP.Name = "lblClient2IP";
            this.lblClient2IP.Size = new System.Drawing.Size(20, 17);
            this.lblClient2IP.TabIndex = 1;
            this.lblClient2IP.Text = "IP";
            // 
            // txtRemotePort
            // 
            this.txtRemotePort.Location = new System.Drawing.Point(97, 50);
            this.txtRemotePort.Name = "txtRemotePort";
            this.txtRemotePort.Size = new System.Drawing.Size(167, 22);
            this.txtRemotePort.TabIndex = 4;
            // 
            // txtRemoteIP
            // 
            this.txtRemoteIP.Location = new System.Drawing.Point(97, 22);
            this.txtRemoteIP.Name = "txtRemoteIP";
            this.txtRemoteIP.Size = new System.Drawing.Size(167, 22);
            this.txtRemoteIP.TabIndex = 3;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(669, 107);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lstMessage
            // 
            this.lstMessage.FormattingEnabled = true;
            this.lstMessage.ItemHeight = 16;
            this.lstMessage.Location = new System.Drawing.Point(51, 198);
            this.lstMessage.Name = "lstMessage";
            this.lstMessage.Size = new System.Drawing.Size(572, 148);
            this.lstMessage.TabIndex = 0;
            this.lstMessage.TabStop = false;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(51, 365);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(572, 22);
            this.txtMessage.TabIndex = 6;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(669, 364);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtChatName
            // 
            this.txtChatName.Location = new System.Drawing.Point(323, 13);
            this.txtChatName.Name = "txtChatName";
            this.txtChatName.Size = new System.Drawing.Size(179, 22);
            this.txtChatName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Please enter your chat name here: ";
            // 
            // frmChatApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtChatName);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.lstMessage);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.gpClient2);
            this.Controls.Add(this.gpClient1);
            this.Name = "frmChatApp";
            this.Text = "Chat Form";
            this.Load += new System.EventHandler(this.frmChatApp_Load);
            this.gpClient1.ResumeLayout(false);
            this.gpClient1.PerformLayout();
            this.gpClient2.ResumeLayout(false);
            this.gpClient2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpClient1;
        private System.Windows.Forms.GroupBox gpClient2;
        private System.Windows.Forms.Label lblClient1Port;
        private System.Windows.Forms.Label lblClient1IP;
        private System.Windows.Forms.TextBox txtLocalPort;
        private System.Windows.Forms.TextBox txtLocalIP;
        private System.Windows.Forms.Label lblClient2Port;
        private System.Windows.Forms.Label lblClient2IP;
        private System.Windows.Forms.TextBox txtRemotePort;
        private System.Windows.Forms.TextBox txtRemoteIP;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lstMessage;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtChatName;
        private System.Windows.Forms.Label label1;
    }
}

