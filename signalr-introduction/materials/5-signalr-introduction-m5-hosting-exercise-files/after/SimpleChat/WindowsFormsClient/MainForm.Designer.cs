namespace WindowsFormsClient
{
    partial class MainForm
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
            this.bnConnect = new System.Windows.Forms.Button();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.bnSend = new System.Windows.Forms.Button();
            this.messages = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bnConnect
            // 
            this.bnConnect.Location = new System.Drawing.Point(12, 12);
            this.bnConnect.Name = "bnConnect";
            this.bnConnect.Size = new System.Drawing.Size(424, 23);
            this.bnConnect.TabIndex = 0;
            this.bnConnect.Text = "Connect";
            this.bnConnect.UseVisualStyleBackColor = true;
            this.bnConnect.Click += new System.EventHandler(this.bnConnect_Click);
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(13, 45);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(323, 20);
            this.tbMessage.TabIndex = 1;
            // 
            // bnSend
            // 
            this.bnSend.Location = new System.Drawing.Point(354, 42);
            this.bnSend.Name = "bnSend";
            this.bnSend.Size = new System.Drawing.Size(82, 23);
            this.bnSend.TabIndex = 2;
            this.bnSend.Text = "Send";
            this.bnSend.UseVisualStyleBackColor = true;
            this.bnSend.Click += new System.EventHandler(this.bnSend_Click);
            // 
            // messages
            // 
            this.messages.FormattingEnabled = true;
            this.messages.Location = new System.Drawing.Point(13, 79);
            this.messages.Name = "messages";
            this.messages.Size = new System.Drawing.Size(423, 342);
            this.messages.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 440);
            this.Controls.Add(this.messages);
            this.Controls.Add(this.bnSend);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.bnConnect);
            this.Name = "MainForm";
            this.Text = "Simple Chat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnConnect;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Button bnSend;
        private System.Windows.Forms.ListBox messages;
    }
}

