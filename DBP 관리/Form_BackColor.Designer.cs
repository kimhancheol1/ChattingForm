namespace DBP_관리 {
	partial class Form_BackColor {
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
			this.groupBox_BackColor = new System.Windows.Forms.GroupBox();
			this.label_BackColor_Title = new System.Windows.Forms.Label();
			this.button_BackColor = new System.Windows.Forms.Button();
			this.checkBox_BackColor_LightMode = new System.Windows.Forms.CheckBox();
			this.checkBox_BackColor_DarkMode = new System.Windows.Forms.CheckBox();
			this.groupBox_BackColor.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox_BackColor
			// 
			this.groupBox_BackColor.Controls.Add(this.button_BackColor);
			this.groupBox_BackColor.Controls.Add(this.checkBox_BackColor_LightMode);
			this.groupBox_BackColor.Controls.Add(this.checkBox_BackColor_DarkMode);
			this.groupBox_BackColor.ForeColor = System.Drawing.Color.White;
			this.groupBox_BackColor.Location = new System.Drawing.Point(54, 117);
			this.groupBox_BackColor.Name = "groupBox_BackColor";
			this.groupBox_BackColor.Size = new System.Drawing.Size(168, 203);
			this.groupBox_BackColor.TabIndex = 9;
			this.groupBox_BackColor.TabStop = false;
			this.groupBox_BackColor.Text = "변경할 테마 체크";
			// 
			// label_BackColor_Title
			// 
			this.label_BackColor_Title.AutoSize = true;
			this.label_BackColor_Title.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label_BackColor_Title.Location = new System.Drawing.Point(54, 45);
			this.label_BackColor_Title.Name = "label_BackColor_Title";
			this.label_BackColor_Title.Size = new System.Drawing.Size(168, 46);
			this.label_BackColor_Title.TabIndex = 10;
			this.label_BackColor_Title.Text = "테마 변경";
			// 
			// button_BackColor
			// 
			this.button_BackColor.BackColor = System.Drawing.Color.White;
			this.button_BackColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button_BackColor.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button_BackColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.button_BackColor.Location = new System.Drawing.Point(37, 143);
			this.button_BackColor.Name = "button_BackColor";
			this.button_BackColor.Size = new System.Drawing.Size(94, 29);
			this.button_BackColor.TabIndex = 21;
			this.button_BackColor.Text = "적용하기";
			this.button_BackColor.UseVisualStyleBackColor = false;
			this.button_BackColor.Click += new System.EventHandler(this.button_BackColor_Click);
			// 
			// checkBox_BackColor_LightMode
			// 
			this.checkBox_BackColor_LightMode.AutoSize = true;
			this.checkBox_BackColor_LightMode.Location = new System.Drawing.Point(29, 88);
			this.checkBox_BackColor_LightMode.Name = "checkBox_BackColor_LightMode";
			this.checkBox_BackColor_LightMode.Size = new System.Drawing.Size(111, 24);
			this.checkBox_BackColor_LightMode.TabIndex = 20;
			this.checkBox_BackColor_LightMode.Text = "라이트 모드";
			this.checkBox_BackColor_LightMode.UseVisualStyleBackColor = true;
			this.checkBox_BackColor_LightMode.CheckedChanged += new System.EventHandler(this.checkBox_BackColor_LightMode_CheckedChanged);
			// 
			// checkBox_BackColor_DarkMode
			// 
			this.checkBox_BackColor_DarkMode.AutoSize = true;
			this.checkBox_BackColor_DarkMode.Location = new System.Drawing.Point(29, 31);
			this.checkBox_BackColor_DarkMode.Name = "checkBox_BackColor_DarkMode";
			this.checkBox_BackColor_DarkMode.Size = new System.Drawing.Size(96, 24);
			this.checkBox_BackColor_DarkMode.TabIndex = 19;
			this.checkBox_BackColor_DarkMode.Text = "다크 모드";
			this.checkBox_BackColor_DarkMode.UseVisualStyleBackColor = true;
			this.checkBox_BackColor_DarkMode.CheckedChanged += new System.EventHandler(this.checkBox_BackColor_DarkMode_CheckedChanged);
			// 
			// Form_BackColor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.ClientSize = new System.Drawing.Size(276, 354);
			this.Controls.Add(this.label_BackColor_Title);
			this.Controls.Add(this.groupBox_BackColor);
			this.ForeColor = System.Drawing.Color.White;
			this.Name = "Form_BackColor";
			this.Text = "테마 변경";
			this.groupBox_BackColor.ResumeLayout(false);
			this.groupBox_BackColor.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private GroupBox groupBox_BackColor;
		private Label label_BackColor_Title;
		private Button button_BackColor;
		private CheckBox checkBox_BackColor_LightMode;
		private CheckBox checkBox_BackColor_DarkMode;
	}
}