namespace _20206_03_17_longlabel
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
            this.label1 = new System.Windows.Forms.Label();
            this.longlabel = new System.Windows.Forms.Label();
            this.Qu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 0;
            // 
            // longlabel
            // 
            this.longlabel.AutoSize = true;
            this.longlabel.Location = new System.Drawing.Point(95, 181);
            this.longlabel.Name = "longlabel";
            this.longlabel.Size = new System.Drawing.Size(0, 12);
            this.longlabel.TabIndex = 1;
            // 
            // Qu
            // 
            this.Qu.Location = new System.Drawing.Point(97, 42);
            this.Qu.Name = "Qu";
            this.Qu.Size = new System.Drawing.Size(75, 23);
            this.Qu.TabIndex = 2;
            this.Qu.Text = "잔 다르크";
            this.Qu.UseVisualStyleBackColor = true;
            this.Qu.Click += new System.EventHandler(this.Qu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 294);
            this.Controls.Add(this.Qu);
            this.Controls.Add(this.longlabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "longlabel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label longlabel;
        private System.Windows.Forms.Button Qu;
    }
}

