namespace DBP_관리 {
	partial class Form_Birthday {
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
			this.label_Birthday_Title = new System.Windows.Forms.Label();
			this.groupBox_Birthday_Month = new System.Windows.Forms.GroupBox();
			this.listBox_Birthday_Month = new System.Windows.Forms.ListBox();
			this.groupBox_Birthday_Today = new System.Windows.Forms.GroupBox();
			this.listBox_Birthday_Today = new System.Windows.Forms.ListBox();
			this.groupBox_Birthday_Month.SuspendLayout();
			this.groupBox_Birthday_Today.SuspendLayout();
			this.SuspendLayout();
			// 
			// label_Birthday_Title
			// 
			this.label_Birthday_Title.AutoSize = true;
			this.label_Birthday_Title.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label_Birthday_Title.Location = new System.Drawing.Point(81, 34);
			this.label_Birthday_Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label_Birthday_Title.Name = "label_Birthday_Title";
			this.label_Birthday_Title.Size = new System.Drawing.Size(202, 37);
			this.label_Birthday_Title.TabIndex = 3;
			this.label_Birthday_Title.Text = "00월 생일 목록";
			// 
			// groupBox_Birthday_Month
			// 
			this.groupBox_Birthday_Month.Controls.Add(this.listBox_Birthday_Month);
			this.groupBox_Birthday_Month.ForeColor = System.Drawing.Color.White;
			this.groupBox_Birthday_Month.Location = new System.Drawing.Point(23, 194);
			this.groupBox_Birthday_Month.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox_Birthday_Month.Name = "groupBox_Birthday_Month";
			this.groupBox_Birthday_Month.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox_Birthday_Month.Size = new System.Drawing.Size(313, 207);
			this.groupBox_Birthday_Month.TabIndex = 9;
			this.groupBox_Birthday_Month.TabStop = false;
			this.groupBox_Birthday_Month.Text = "이번달 생일";
			// 
			// listBox_Birthday_Month
			// 
			this.listBox_Birthday_Month.FormattingEnabled = true;
			this.listBox_Birthday_Month.ItemHeight = 15;
			this.listBox_Birthday_Month.Location = new System.Drawing.Point(14, 27);
			this.listBox_Birthday_Month.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.listBox_Birthday_Month.Name = "listBox_Birthday_Month";
			this.listBox_Birthday_Month.Size = new System.Drawing.Size(286, 169);
			this.listBox_Birthday_Month.TabIndex = 1;
			// 
			// groupBox_Birthday_Today
			// 
			this.groupBox_Birthday_Today.Controls.Add(this.listBox_Birthday_Today);
			this.groupBox_Birthday_Today.ForeColor = System.Drawing.Color.White;
			this.groupBox_Birthday_Today.Location = new System.Drawing.Point(23, 86);
			this.groupBox_Birthday_Today.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox_Birthday_Today.Name = "groupBox_Birthday_Today";
			this.groupBox_Birthday_Today.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox_Birthday_Today.Size = new System.Drawing.Size(313, 92);
			this.groupBox_Birthday_Today.TabIndex = 7;
			this.groupBox_Birthday_Today.TabStop = false;
			this.groupBox_Birthday_Today.Text = "오늘 생일";
			// 
			// listBox_Birthday_Today
			// 
			this.listBox_Birthday_Today.FormattingEnabled = true;
			this.listBox_Birthday_Today.ItemHeight = 15;
			this.listBox_Birthday_Today.Location = new System.Drawing.Point(14, 19);
			this.listBox_Birthday_Today.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.listBox_Birthday_Today.Name = "listBox_Birthday_Today";
			this.listBox_Birthday_Today.Size = new System.Drawing.Size(286, 64);
			this.listBox_Birthday_Today.TabIndex = 1;
			// 
			// Form_Birthday
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.ClientSize = new System.Drawing.Size(359, 415);
			this.Controls.Add(this.groupBox_Birthday_Month);
			this.Controls.Add(this.groupBox_Birthday_Today);
			this.Controls.Add(this.label_Birthday_Title);
			this.ForeColor = System.Drawing.Color.White;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "Form_Birthday";
			this.Text = "생일 목록";
			this.groupBox_Birthday_Month.ResumeLayout(false);
			this.groupBox_Birthday_Today.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label_Birthday_Title;
		private GroupBox groupBox_Birthday_Month;
		private GroupBox groupBox_Birthday_Today;
		private ListBox listBox_Birthday_Month;
		private ListBox listBox_Birthday_Today;
	}
}