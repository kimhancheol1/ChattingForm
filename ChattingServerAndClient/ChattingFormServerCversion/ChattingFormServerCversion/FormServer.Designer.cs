namespace ChattingFormServerCversion
{
    partial class FormServer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxUser = new System.Windows.Forms.ListBox();
            this.listBoxAccessLog = new System.Windows.Forms.ListBox();
            this.listBoxChattingLog = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "임시 C#서버!!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Accessing";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(620, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "MsgLog";
            // 
            // listBoxUser
            // 
            this.listBoxUser.FormattingEnabled = true;
            this.listBoxUser.ItemHeight = 20;
            this.listBoxUser.Location = new System.Drawing.Point(17, 65);
            this.listBoxUser.Name = "listBoxUser";
            this.listBoxUser.Size = new System.Drawing.Size(253, 244);
            this.listBoxUser.TabIndex = 14;
            // 
            // listBoxAccessLog
            // 
            this.listBoxAccessLog.FormattingEnabled = true;
            this.listBoxAccessLog.ItemHeight = 20;
            this.listBoxAccessLog.Location = new System.Drawing.Point(289, 65);
            this.listBoxAccessLog.Name = "listBoxAccessLog";
            this.listBoxAccessLog.Size = new System.Drawing.Size(313, 244);
            this.listBoxAccessLog.TabIndex = 15;
            // 
            // listBoxChattingLog
            // 
            this.listBoxChattingLog.FormattingEnabled = true;
            this.listBoxChattingLog.ItemHeight = 20;
            this.listBoxChattingLog.Location = new System.Drawing.Point(620, 65);
            this.listBoxChattingLog.Name = "listBoxChattingLog";
            this.listBoxChattingLog.Size = new System.Drawing.Size(384, 244);
            this.listBoxChattingLog.TabIndex = 16;
            // 
            // FormServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 347);
            this.Controls.Add(this.listBoxChattingLog);
            this.Controls.Add(this.listBoxAccessLog);
            this.Controls.Add(this.listBoxUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "FormServer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormServer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox listBoxUser;
        private ListBox listBoxAccessLog;
        private ListBox listBoxChattingLog;
    }
}