namespace DBP_관리 {
	partial class Form_Weather {
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
			this.groupBox_Weather = new System.Windows.Forms.GroupBox();
			this.listBox_Weather = new System.Windows.Forms.ListBox();
			this.label_Weather_Title = new System.Windows.Forms.Label();
			this.groupBox_Weather.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox_Weather
			// 
			this.groupBox_Weather.Controls.Add(this.listBox_Weather);
			this.groupBox_Weather.ForeColor = System.Drawing.Color.White;
			this.groupBox_Weather.Location = new System.Drawing.Point(33, 115);
			this.groupBox_Weather.Name = "groupBox_Weather";
			this.groupBox_Weather.Size = new System.Drawing.Size(720, 187);
			this.groupBox_Weather.TabIndex = 9;
			this.groupBox_Weather.TabStop = false;
			this.groupBox_Weather.Text = "날씨";
			// 
			// listBox_Weather
			// 
			this.listBox_Weather.FormattingEnabled = true;
			this.listBox_Weather.HorizontalScrollbar = true;
			this.listBox_Weather.ItemHeight = 20;
			this.listBox_Weather.Location = new System.Drawing.Point(23, 29);
			this.listBox_Weather.Name = "listBox_Weather";
			this.listBox_Weather.Size = new System.Drawing.Size(669, 144);
			this.listBox_Weather.TabIndex = 2;
			// 
			// label_Weather_Title
			// 
			this.label_Weather_Title.AutoSize = true;
			this.label_Weather_Title.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label_Weather_Title.Location = new System.Drawing.Point(269, 45);
			this.label_Weather_Title.Name = "label_Weather_Title";
			this.label_Weather_Title.Size = new System.Drawing.Size(248, 46);
			this.label_Weather_Title.TabIndex = 11;
			this.label_Weather_Title.Text = "주요 날씨 정보";
			// 
			// Form_Weather
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.ClientSize = new System.Drawing.Size(787, 328);
			this.Controls.Add(this.label_Weather_Title);
			this.Controls.Add(this.groupBox_Weather);
			this.ForeColor = System.Drawing.Color.White;
			this.Name = "Form_Weather";
			this.Text = "Form_Weather";
			this.groupBox_Weather.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private GroupBox groupBox_Weather;
		private ListBox listBox_Weather;
		private Label label_Weather_Title;
	}
}