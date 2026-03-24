namespace _002_bmi_from
{
    partial class txt
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
            this.hi = new System.Windows.Forms.Label();
            this.mu = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lastbmi = new System.Windows.Forms.Label();
            this.txtH = new System.Windows.Forms.TextBox();
            this.txtW = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // hi
            // 
            this.hi.AutoSize = true;
            this.hi.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hi.Location = new System.Drawing.Point(24, 22);
            this.hi.Name = "hi";
            this.hi.Size = new System.Drawing.Size(44, 15);
            this.hi.TabIndex = 0;
            this.hi.Text = "키(cm)";
            this.hi.Click += new System.EventHandler(this.label1_Click);
            // 
            // mu
            // 
            this.mu.AutoSize = true;
            this.mu.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mu.Location = new System.Drawing.Point(24, 87);
            this.mu.Name = "mu";
            this.mu.Size = new System.Drawing.Size(54, 15);
            this.mu.TabIndex = 1;
            this.mu.Text = "체중(kg)";
            this.mu.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(365, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 79);
            this.button1.TabIndex = 4;
            this.button1.Text = "BMI 계산";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lastbmi
            // 
            this.lastbmi.AutoSize = true;
            this.lastbmi.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastbmi.Location = new System.Drawing.Point(24, 212);
            this.lastbmi.Name = "lastbmi";
            this.lastbmi.Size = new System.Drawing.Size(48, 15);
            this.lastbmi.TabIndex = 5;
            this.lastbmi.Text = "BMI = ";
            this.lastbmi.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtH
            // 
            this.txtH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtH.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtH.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtH.Location = new System.Drawing.Point(376, 20);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(88, 15);
            this.txtH.TabIndex = 6;
            this.txtH.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // txtW
            // 
            this.txtW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtW.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtW.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtW.Location = new System.Drawing.Point(376, 87);
            this.txtW.Name = "txtW";
            this.txtW.Size = new System.Drawing.Size(88, 15);
            this.txtW.TabIndex = 7;
            // 
            // txt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(488, 267);
            this.Controls.Add(this.txtW);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.lastbmi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mu);
            this.Controls.Add(this.hi);
            this.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.Name = "txt";
            this.Text = "BMI 측정기";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hi;
        private System.Windows.Forms.Label mu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lastbmi;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.TextBox txtW;
    }
}

