namespace DBP_관리 {
	partial class FormAdmin_Dpt_Udt {
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
			this.button_Dpt_Udt = new System.Windows.Forms.Button();
			this.textBox_Dpt_Upt_Name = new System.Windows.Forms.TextBox();
			this.label_Dpt_Upt_Name = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label_Chat_Title
			// 
			this.label_Chat_Title.AutoSize = true;
			this.label_Chat_Title.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label_Chat_Title.ForeColor = System.Drawing.Color.White;
			this.label_Chat_Title.Location = new System.Drawing.Point(118, 28);
			this.label_Chat_Title.Name = "label_Chat_Title";
			this.label_Chat_Title.Size = new System.Drawing.Size(142, 35);
			this.label_Chat_Title.TabIndex = 9;
			this.label_Chat_Title.Text = "[부서] 수정";
			// 
			// button_Dpt_Udt
			// 
			this.button_Dpt_Udt.BackColor = System.Drawing.Color.White;
			this.button_Dpt_Udt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button_Dpt_Udt.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button_Dpt_Udt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.button_Dpt_Udt.Location = new System.Drawing.Point(37, 157);
			this.button_Dpt_Udt.Name = "button_Dpt_Udt";
			this.button_Dpt_Udt.Size = new System.Drawing.Size(285, 31);
			this.button_Dpt_Udt.TabIndex = 11;
			this.button_Dpt_Udt.Text = "수정하기";
			this.button_Dpt_Udt.UseVisualStyleBackColor = false;
			// 
			// textBox_Dpt_Upt_Name
			// 
			this.textBox_Dpt_Upt_Name.Location = new System.Drawing.Point(117, 98);
			this.textBox_Dpt_Upt_Name.Name = "textBox_Dpt_Upt_Name";
			this.textBox_Dpt_Upt_Name.Size = new System.Drawing.Size(205, 27);
			this.textBox_Dpt_Upt_Name.TabIndex = 16;
			// 
			// label_Dpt_Upt_Name
			// 
			this.label_Dpt_Upt_Name.AutoSize = true;
			this.label_Dpt_Upt_Name.ForeColor = System.Drawing.Color.White;
			this.label_Dpt_Upt_Name.Location = new System.Drawing.Point(37, 101);
			this.label_Dpt_Upt_Name.Name = "label_Dpt_Upt_Name";
			this.label_Dpt_Upt_Name.Size = new System.Drawing.Size(74, 20);
			this.label_Dpt_Upt_Name.TabIndex = 15;
			this.label_Dpt_Upt_Name.Text = "부서 이름";
			// 
			// FormAdmin_Dpt_Udt
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.ClientSize = new System.Drawing.Size(371, 225);
			this.Controls.Add(this.textBox_Dpt_Upt_Name);
			this.Controls.Add(this.label_Dpt_Upt_Name);
			this.Controls.Add(this.button_Dpt_Udt);
			this.Controls.Add(this.label_Chat_Title);
			this.Name = "FormAdmin_Dpt_Udt";
			this.Text = "부서 수정";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label_Chat_Title;
		private Button button_Dpt_Udt;
		private TextBox textBox_Dpt_Upt_Name;
		private Label label_Dpt_Upt_Name;
	}
}