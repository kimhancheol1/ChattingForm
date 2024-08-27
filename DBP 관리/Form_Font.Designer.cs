namespace DBP_관리
{
    partial class Form_Font
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
            this.label_BackColor_Title = new System.Windows.Forms.Label();
            this.groupBox_BackColor = new System.Windows.Forms.GroupBox();
            this.button_BackColor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.groupBox_BackColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_BackColor_Title
            // 
            this.label_BackColor_Title.AutoSize = true;
            this.label_BackColor_Title.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_BackColor_Title.Location = new System.Drawing.Point(151, 22);
            this.label_BackColor_Title.Name = "label_BackColor_Title";
            this.label_BackColor_Title.Size = new System.Drawing.Size(168, 46);
            this.label_BackColor_Title.TabIndex = 12;
            this.label_BackColor_Title.Text = "폰트 변경";
            // 
            // groupBox_BackColor
            // 
            this.groupBox_BackColor.Controls.Add(this.label3);
            this.groupBox_BackColor.Controls.Add(this.label4);
            this.groupBox_BackColor.Controls.Add(this.comboBox3);
            this.groupBox_BackColor.Controls.Add(this.comboBox4);
            this.groupBox_BackColor.Controls.Add(this.button_BackColor);
            this.groupBox_BackColor.ForeColor = System.Drawing.Color.White;
            this.groupBox_BackColor.Location = new System.Drawing.Point(74, 81);
            this.groupBox_BackColor.Name = "groupBox_BackColor";
            this.groupBox_BackColor.Size = new System.Drawing.Size(324, 218);
            this.groupBox_BackColor.TabIndex = 11;
            this.groupBox_BackColor.TabStop = false;
            // 
            // button_BackColor
            // 
            this.button_BackColor.BackColor = System.Drawing.Color.White;
            this.button_BackColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_BackColor.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_BackColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.button_BackColor.Location = new System.Drawing.Point(196, 174);
            this.button_BackColor.Name = "button_BackColor";
            this.button_BackColor.Size = new System.Drawing.Size(94, 29);
            this.button_BackColor.TabIndex = 21;
            this.button_BackColor.Text = "적용하기";
            this.button_BackColor.UseVisualStyleBackColor = false;
            this.button_BackColor.Click += new System.EventHandler(this.button_BackColor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "폰트 크기 변경";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(47, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "폰트 변경";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "8",
            "10",
            "12",
            "14",
            "16"});
            this.comboBox3.Location = new System.Drawing.Point(139, 111);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(151, 28);
            this.comboBox3.TabIndex = 23;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "맑은 고딕",
            "바탕체",
            "휴먼매직체",
            "휴먼편지체",
            "궁서체"});
            this.comboBox4.Location = new System.Drawing.Point(139, 37);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(151, 28);
            this.comboBox4.TabIndex = 22;
            // 
            // Form_Font
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(499, 348);
            this.Controls.Add(this.label_BackColor_Title);
            this.Controls.Add(this.groupBox_BackColor);
            this.Name = "Form_Font";
            this.Text = "Form_Font";
            this.groupBox_BackColor.ResumeLayout(false);
            this.groupBox_BackColor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_BackColor_Title;
        private GroupBox groupBox_BackColor;
        private Label label3;
        private Label label4;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private Button button_BackColor;
    }
}