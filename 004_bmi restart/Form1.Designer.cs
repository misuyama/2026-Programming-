namespace _004_bmi_restart
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.txthigh = new System.Windows.Forms.TextBox();
            this.texthigh = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtweight = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.result1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(468, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "변환하기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txthigh
            // 
            this.txthigh.Location = new System.Drawing.Point(245, 83);
            this.txthigh.Name = "txthigh";
            this.txthigh.Size = new System.Drawing.Size(100, 21);
            this.txthigh.TabIndex = 1;
            // 
            // texthigh
            // 
            this.texthigh.AutoSize = true;
            this.texthigh.Location = new System.Drawing.Point(90, 86);
            this.texthigh.Name = "texthigh";
            this.texthigh.Size = new System.Drawing.Size(117, 12);
            this.texthigh.TabIndex = 2;
            this.texthigh.Text = "키를 입력하십시오 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "체중을 입력하십시오 : ";
            // 
            // txtweight
            // 
            this.txtweight.Location = new System.Drawing.Point(245, 167);
            this.txtweight.Name = "txtweight";
            this.txtweight.Size = new System.Drawing.Size(100, 21);
            this.txtweight.TabIndex = 4;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(604, 141);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 12);
            this.result.TabIndex = 5;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(665, 253);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // result1
            // 
            this.result1.AutoSize = true;
            this.result1.Location = new System.Drawing.Point(466, 141);
            this.result1.Name = "result1";
            this.result1.Size = new System.Drawing.Size(0, 12);
            this.result1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.result1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.txtweight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.texthigh);
            this.Controls.Add(this.txthigh);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "bmi 측정기";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txthigh;
        private System.Windows.Forms.Label texthigh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtweight;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label result1;
    }
}

