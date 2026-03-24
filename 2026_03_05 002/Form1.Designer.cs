namespace _2026_03_05_002
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
            this.sf = new System.Windows.Forms.Button();
            this.fs = new System.Windows.Forms.Button();
            this.textsub = new System.Windows.Forms.TextBox();
            this.textfire = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sf
            // 
            this.sf.Location = new System.Drawing.Point(366, 125);
            this.sf.Name = "sf";
            this.sf.Size = new System.Drawing.Size(75, 23);
            this.sf.TabIndex = 0;
            this.sf.Text = "->";
            this.sf.UseVisualStyleBackColor = true;
            this.sf.Click += new System.EventHandler(this.sf_Click);
            // 
            // fs
            // 
            this.fs.Location = new System.Drawing.Point(366, 242);
            this.fs.Name = "fs";
            this.fs.Size = new System.Drawing.Size(75, 23);
            this.fs.TabIndex = 1;
            this.fs.Text = "<-";
            this.fs.UseVisualStyleBackColor = true;
            this.fs.Click += new System.EventHandler(this.fs_Click);
            // 
            // textsub
            // 
            this.textsub.Location = new System.Drawing.Point(121, 189);
            this.textsub.Name = "textsub";
            this.textsub.Size = new System.Drawing.Size(100, 21);
            this.textsub.TabIndex = 2;
            // 
            // textfire
            // 
            this.textfire.Location = new System.Drawing.Point(572, 189);
            this.textfire.Name = "textfire";
            this.textfire.Size = new System.Drawing.Size(100, 21);
            this.textfire.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "섭씨";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(572, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "화씨";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textfire);
            this.Controls.Add(this.textsub);
            this.Controls.Add(this.fs);
            this.Controls.Add(this.sf);
            this.Name = "Form1";
            this.Text = "섭씨, 화씨 변환기";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sf;
        private System.Windows.Forms.Button fs;
        private System.Windows.Forms.TextBox textsub;
        private System.Windows.Forms.TextBox textfire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

