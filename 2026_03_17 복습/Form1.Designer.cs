namespace _2026_03_17_복습
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
            this.namebutton = new System.Windows.Forms.Button();
            this.inputname = new System.Windows.Forms.Label();
            this.namebox = new System.Windows.Forms.TextBox();
            this.hide = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // namebutton
            // 
            this.namebutton.Location = new System.Drawing.Point(282, 47);
            this.namebutton.Name = "namebutton";
            this.namebutton.Size = new System.Drawing.Size(75, 23);
            this.namebutton.TabIndex = 0;
            this.namebutton.Text = "입력";
            this.namebutton.UseVisualStyleBackColor = true;
            this.namebutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputname
            // 
            this.inputname.AutoSize = true;
            this.inputname.Location = new System.Drawing.Point(-1, 52);
            this.inputname.Name = "inputname";
            this.inputname.Size = new System.Drawing.Size(111, 12);
            this.inputname.TabIndex = 1;
            this.inputname.Text = "이름은 무엇인가요?";
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(138, 49);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(100, 21);
            this.namebox.TabIndex = 2;
            // 
            // hide
            // 
            this.hide.AutoSize = true;
            this.hide.Location = new System.Drawing.Point(138, 114);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(0, 12);
            this.hide.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 192);
            this.Controls.Add(this.hide);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.inputname);
            this.Controls.Add(this.namebutton);
            this.Name = "Form1";
            this.Text = "테스트";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button namebutton;
        private System.Windows.Forms.Label inputname;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.Label hide;
    }
}

