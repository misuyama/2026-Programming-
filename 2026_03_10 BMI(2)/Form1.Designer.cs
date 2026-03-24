namespace _2026_03_10_BMI_2_
{
    partial class BMI측정
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.txthi = new System.Windows.Forms.Label();
            this.txtwi = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bmi1 = new System.Windows.Forms.Label();
            this.bmi2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txthi
            // 
            this.txthi.AutoSize = true;
            this.txthi.Location = new System.Drawing.Point(118, 112);
            this.txthi.Name = "txthi";
            this.txthi.Size = new System.Drawing.Size(53, 12);
            this.txthi.TabIndex = 0;
            this.txthi.Text = "체중입력";
            this.txthi.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtwi
            // 
            this.txtwi.AutoSize = true;
            this.txtwi.Location = new System.Drawing.Point(120, 208);
            this.txtwi.Name = "txtwi";
            this.txtwi.Size = new System.Drawing.Size(69, 12);
            this.txtwi.TabIndex = 1;
            this.txtwi.Text = "키(cm)입력";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(395, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(395, 208);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(395, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "변환";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bmi1
            // 
            this.bmi1.AutoSize = true;
            this.bmi1.Location = new System.Drawing.Point(607, 112);
            this.bmi1.Name = "bmi1";
            this.bmi1.Size = new System.Drawing.Size(0, 12);
            this.bmi1.TabIndex = 5;
            // 
            // bmi2
            // 
            this.bmi2.AutoSize = true;
            this.bmi2.Location = new System.Drawing.Point(609, 208);
            this.bmi2.Name = "bmi2";
            this.bmi2.Size = new System.Drawing.Size(0, 12);
            this.bmi2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(70, 306);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 80);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // BMI측정
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bmi2);
            this.Controls.Add(this.bmi1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtwi);
            this.Controls.Add(this.txthi);
            this.Name = "BMI측정";
            this.Text = "BMI측정기(2)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txthi;
        private System.Windows.Forms.Label txtwi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label bmi1;
        private System.Windows.Forms.Label bmi2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

