namespace TabControl
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RdbT3 = new System.Windows.Forms.RadioButton();
            this.RdbT2 = new System.Windows.Forms.RadioButton();
            this.RdbT1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RdbS3 = new System.Windows.Forms.RadioButton();
            this.RdbS2 = new System.Windows.Forms.RadioButton();
            this.RdbS1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TxtSize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ChkF2 = new System.Windows.Forms.CheckBox();
            this.ChkF1 = new System.Windows.Forms.CheckBox();
            this.RdbF3 = new System.Windows.Forms.RadioButton();
            this.RdbF2 = new System.Windows.Forms.RadioButton();
            this.RdbF1 = new System.Windows.Forms.RadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ChkA3 = new System.Windows.Forms.CheckBox();
            this.ChkA2 = new System.Windows.Forms.CheckBox();
            this.ChkA1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ChkE2 = new System.Windows.Forms.RadioButton();
            this.ChkE1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnOk = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(428, 220);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(420, 192);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "一般";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RdbT3);
            this.panel2.Controls.Add(this.RdbT2);
            this.panel2.Controls.Add(this.RdbT1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(218, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 145);
            this.panel2.TabIndex = 1;
            // 
            // RdbT3
            // 
            this.RdbT3.AutoSize = true;
            this.RdbT3.Location = new System.Drawing.Point(26, 103);
            this.RdbT3.Name = "RdbT3";
            this.RdbT3.Size = new System.Drawing.Size(70, 19);
            this.RdbT3.TabIndex = 3;
            this.RdbT3.TabStop = true;
            this.RdbT3.Text = "大圖示";
            this.RdbT3.UseVisualStyleBackColor = true;
            // 
            // RdbT2
            // 
            this.RdbT2.AutoSize = true;
            this.RdbT2.Location = new System.Drawing.Point(26, 70);
            this.RdbT2.Name = "RdbT2";
            this.RdbT2.Size = new System.Drawing.Size(70, 19);
            this.RdbT2.TabIndex = 2;
            this.RdbT2.TabStop = true;
            this.RdbT2.Text = "小圖示";
            this.RdbT2.UseVisualStyleBackColor = true;
            // 
            // RdbT1
            // 
            this.RdbT1.AutoSize = true;
            this.RdbT1.Location = new System.Drawing.Point(26, 33);
            this.RdbT1.Name = "RdbT1";
            this.RdbT1.Size = new System.Drawing.Size(40, 19);
            this.RdbT1.TabIndex = 1;
            this.RdbT1.TabStop = true;
            this.RdbT1.Text = "無";
            this.RdbT1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "工具列";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RdbS3);
            this.panel1.Controls.Add(this.RdbS2);
            this.panel1.Controls.Add(this.RdbS1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 145);
            this.panel1.TabIndex = 0;
            // 
            // RdbS3
            // 
            this.RdbS3.AutoSize = true;
            this.RdbS3.Location = new System.Drawing.Point(26, 103);
            this.RdbS3.Name = "RdbS3";
            this.RdbS3.Size = new System.Drawing.Size(46, 19);
            this.RdbS3.TabIndex = 3;
            this.RdbS3.TabStop = true;
            this.RdbS3.Text = "Mac";
            this.RdbS3.UseVisualStyleBackColor = true;
            // 
            // RdbS2
            // 
            this.RdbS2.AutoSize = true;
            this.RdbS2.Location = new System.Drawing.Point(26, 68);
            this.RdbS2.Name = "RdbS2";
            this.RdbS2.Size = new System.Drawing.Size(60, 19);
            this.RdbS2.TabIndex = 2;
            this.RdbS2.TabStop = true;
            this.RdbS2.Text = "Linux";
            this.RdbS2.UseVisualStyleBackColor = true;
            // 
            // RdbS1
            // 
            this.RdbS1.AutoSize = true;
            this.RdbS1.Location = new System.Drawing.Point(26, 33);
            this.RdbS1.Name = "RdbS1";
            this.RdbS1.Size = new System.Drawing.Size(74, 19);
            this.RdbS1.TabIndex = 1;
            this.RdbS1.TabStop = true;
            this.RdbS1.Text = "Windows";
            this.RdbS1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "風格";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TxtSize);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.ChkF2);
            this.tabPage2.Controls.Add(this.ChkF1);
            this.tabPage2.Controls.Add(this.RdbF3);
            this.tabPage2.Controls.Add(this.RdbF2);
            this.tabPage2.Controls.Add(this.RdbF1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(420, 192);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "字型";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TxtSize
            // 
            this.TxtSize.Location = new System.Drawing.Point(287, 27);
            this.TxtSize.Name = "TxtSize";
            this.TxtSize.Size = new System.Drawing.Size(100, 23);
            this.TxtSize.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "字型大小";
            // 
            // ChkF2
            // 
            this.ChkF2.AutoSize = true;
            this.ChkF2.Location = new System.Drawing.Point(215, 131);
            this.ChkF2.Name = "ChkF2";
            this.ChkF2.Size = new System.Drawing.Size(56, 19);
            this.ChkF2.TabIndex = 4;
            this.ChkF2.Text = "斜體";
            this.ChkF2.UseVisualStyleBackColor = true;
            // 
            // ChkF1
            // 
            this.ChkF1.AutoSize = true;
            this.ChkF1.Location = new System.Drawing.Point(215, 78);
            this.ChkF1.Name = "ChkF1";
            this.ChkF1.Size = new System.Drawing.Size(56, 19);
            this.ChkF1.TabIndex = 3;
            this.ChkF1.Text = "粗體";
            this.ChkF1.UseVisualStyleBackColor = true;
            // 
            // RdbF3
            // 
            this.RdbF3.AutoSize = true;
            this.RdbF3.Location = new System.Drawing.Point(26, 131);
            this.RdbF3.Name = "RdbF3";
            this.RdbF3.Size = new System.Drawing.Size(70, 19);
            this.RdbF3.TabIndex = 2;
            this.RdbF3.TabStop = true;
            this.RdbF3.Text = "正黑體";
            this.RdbF3.UseVisualStyleBackColor = true;
            // 
            // RdbF2
            // 
            this.RdbF2.AutoSize = true;
            this.RdbF2.Location = new System.Drawing.Point(26, 78);
            this.RdbF2.Name = "RdbF2";
            this.RdbF2.Size = new System.Drawing.Size(85, 19);
            this.RdbF2.TabIndex = 1;
            this.RdbF2.TabStop = true;
            this.RdbF2.Text = "新細明體";
            this.RdbF2.UseVisualStyleBackColor = true;
            // 
            // RdbF1
            // 
            this.RdbF1.AutoSize = true;
            this.RdbF1.Location = new System.Drawing.Point(26, 31);
            this.RdbF1.Name = "RdbF1";
            this.RdbF1.Size = new System.Drawing.Size(70, 19);
            this.RdbF1.TabIndex = 0;
            this.RdbF1.TabStop = true;
            this.RdbF1.Text = "標楷體";
            this.RdbF1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Controls.Add(this.panel4);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(420, 192);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "編輯";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ChkA3);
            this.panel3.Controls.Add(this.ChkA2);
            this.panel3.Controls.Add(this.ChkA1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(9, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(198, 137);
            this.panel3.TabIndex = 0;
            // 
            // ChkA3
            // 
            this.ChkA3.AutoSize = true;
            this.ChkA3.Location = new System.Drawing.Point(25, 98);
            this.ChkA3.Name = "ChkA3";
            this.ChkA3.Size = new System.Drawing.Size(86, 19);
            this.ChkA3.TabIndex = 3;
            this.ChkA3.Text = "自動縮排";
            this.ChkA3.UseVisualStyleBackColor = true;
            // 
            // ChkA2
            // 
            this.ChkA2.AutoSize = true;
            this.ChkA2.Location = new System.Drawing.Point(25, 67);
            this.ChkA2.Name = "ChkA2";
            this.ChkA2.Size = new System.Drawing.Size(86, 19);
            this.ChkA2.TabIndex = 2;
            this.ChkA2.Text = "自動存檔";
            this.ChkA2.UseVisualStyleBackColor = true;
            // 
            // ChkA1
            // 
            this.ChkA1.AutoSize = true;
            this.ChkA1.Location = new System.Drawing.Point(25, 33);
            this.ChkA1.Name = "ChkA1";
            this.ChkA1.Size = new System.Drawing.Size(86, 19);
            this.ChkA1.TabIndex = 1;
            this.ChkA1.Text = "自動換行";
            this.ChkA1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "自動化設定";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ChkE2);
            this.panel4.Controls.Add(this.ChkE1);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(213, 32);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(198, 137);
            this.panel4.TabIndex = 1;
            // 
            // ChkE2
            // 
            this.ChkE2.AutoSize = true;
            this.ChkE2.Location = new System.Drawing.Point(32, 79);
            this.ChkE2.Name = "ChkE2";
            this.ChkE2.Size = new System.Drawing.Size(68, 19);
            this.ChkE2.TabIndex = 2;
            this.ChkE2.TabStop = true;
            this.ChkE2.Text = "按 ESC";
            this.ChkE2.UseVisualStyleBackColor = true;
            // 
            // ChkE1
            // 
            this.ChkE1.AutoSize = true;
            this.ChkE1.Location = new System.Drawing.Point(32, 35);
            this.ChkE1.Name = "ChkE1";
            this.ChkE1.Size = new System.Drawing.Size(67, 19);
            this.ChkE1.TabIndex = 1;
            this.ChkE1.TabStop = true;
            this.ChkE1.Text = "Alt+F4";
            this.ChkE1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, -2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "結束程式";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(200, 246);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(94, 30);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "放棄";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnOk
            // 
            this.BtnOk.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOk.Location = new System.Drawing.Point(312, 246);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(94, 30);
            this.BtnOk.TabIndex = 2;
            this.BtnOk.Text = "確定";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 301);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton RdbT3;
        private System.Windows.Forms.RadioButton RdbT2;
        private System.Windows.Forms.RadioButton RdbT1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton RdbS3;
        private System.Windows.Forms.RadioButton RdbS2;
        private System.Windows.Forms.RadioButton RdbS1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox TxtSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ChkF2;
        private System.Windows.Forms.CheckBox ChkF1;
        private System.Windows.Forms.RadioButton RdbF3;
        private System.Windows.Forms.RadioButton RdbF2;
        private System.Windows.Forms.RadioButton RdbF1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton ChkE2;
        private System.Windows.Forms.RadioButton ChkE1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox ChkA3;
        private System.Windows.Forms.CheckBox ChkA2;
        private System.Windows.Forms.CheckBox ChkA1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnOk;
    }
}

