namespace DBP_관리 {
	partial class FormAdmin_Dpt_Plus {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.label_Chat_Title = new System.Windows.Forms.Label();
            this.button_Dpt_Plus = new System.Windows.Forms.Button();
            this.label_Dpt_Plus_Name = new System.Windows.Forms.Label();
            this.textBox_Dpt_Plus_Name = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Chat_Title
            // 
            this.label_Chat_Title.AutoSize = true;
            this.label_Chat_Title.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Chat_Title.ForeColor = System.Drawing.Color.White;
            this.label_Chat_Title.Location = new System.Drawing.Point(12, 9);
            this.label_Chat_Title.Name = "label_Chat_Title";
            this.label_Chat_Title.Size = new System.Drawing.Size(161, 35);
            this.label_Chat_Title.TabIndex = 8;
            this.label_Chat_Title.Text = "Registration";
            // 
            // button_Dpt_Plus
            // 
            this.button_Dpt_Plus.BackColor = System.Drawing.Color.White;
            this.button_Dpt_Plus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Dpt_Plus.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Dpt_Plus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.button_Dpt_Plus.Location = new System.Drawing.Point(281, 30);
            this.button_Dpt_Plus.Name = "button_Dpt_Plus";
            this.button_Dpt_Plus.Size = new System.Drawing.Size(65, 27);
            this.button_Dpt_Plus.TabIndex = 12;
            this.button_Dpt_Plus.Text = "추가";
            this.button_Dpt_Plus.UseVisualStyleBackColor = false;
            this.button_Dpt_Plus.Click += new System.EventHandler(this.button_Dpt_Plus_Click);
            // 
            // label_Dpt_Plus_Name
            // 
            this.label_Dpt_Plus_Name.AutoSize = true;
            this.label_Dpt_Plus_Name.ForeColor = System.Drawing.Color.White;
            this.label_Dpt_Plus_Name.Location = new System.Drawing.Point(28, 33);
            this.label_Dpt_Plus_Name.Name = "label_Dpt_Plus_Name";
            this.label_Dpt_Plus_Name.Size = new System.Drawing.Size(54, 20);
            this.label_Dpt_Plus_Name.TabIndex = 13;
            this.label_Dpt_Plus_Name.Text = "부서명";
            // 
            // textBox_Dpt_Plus_Name
            // 
            this.textBox_Dpt_Plus_Name.Location = new System.Drawing.Point(88, 30);
            this.textBox_Dpt_Plus_Name.Name = "textBox_Dpt_Plus_Name";
            this.textBox_Dpt_Plus_Name.Size = new System.Drawing.Size(169, 27);
            this.textBox_Dpt_Plus_Name.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_Dpt_Plus_Name);
            this.groupBox1.Controls.Add(this.button_Dpt_Plus);
            this.groupBox1.Controls.Add(this.label_Dpt_Plus_Name);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 104);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "부서 등록";
            // 
            // FormAdmin_Dpt_Plus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(511, 270);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_Chat_Title);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FormAdmin_Dpt_Plus";
            this.Text = "부서 등록";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Label label_Chat_Title;
		private Button button_Dpt_Plus;
		private Label label_Dpt_Plus_Name;
		private TextBox textBox_Dpt_Plus_Name;
        private GroupBox groupBox1;
    }
}