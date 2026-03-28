namespace _2026_03_25_susi
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
            this.name = new System.Windows.Forms.Label();
            this.jongru = new System.Windows.Forms.Label();
            this.cout = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.Button();
            this.re = new System.Windows.Forms.Button();
            this.name1 = new System.Windows.Forms.TextBox();
            this.cout1 = new System.Windows.Forms.TextBox();
            this.cbx1 = new System.Windows.Forms.ComboBox();
            this.and = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(72, 72);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(29, 12);
            this.name.TabIndex = 0;
            this.name.Text = "이름";
            // 
            // jongru
            // 
            this.jongru.AutoSize = true;
            this.jongru.Location = new System.Drawing.Point(72, 153);
            this.jongru.Name = "jongru";
            this.jongru.Size = new System.Drawing.Size(29, 12);
            this.jongru.TabIndex = 1;
            this.jongru.Text = "종류";
            // 
            // cout
            // 
            this.cout.AutoSize = true;
            this.cout.Location = new System.Drawing.Point(72, 229);
            this.cout.Name = "cout";
            this.cout.Size = new System.Drawing.Size(29, 12);
            this.cout.TabIndex = 2;
            this.cout.Text = "개수";
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(74, 274);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(106, 23);
            this.sum.TabIndex = 3;
            this.sum.Text = "계산";
            this.sum.UseVisualStyleBackColor = true;
            this.sum.Click += new System.EventHandler(this.sum_Click);
            // 
            // re
            // 
            this.re.Location = new System.Drawing.Point(229, 274);
            this.re.Name = "re";
            this.re.Size = new System.Drawing.Size(121, 23);
            this.re.TabIndex = 4;
            this.re.Text = "초기화";
            this.re.UseVisualStyleBackColor = true;
            this.re.Click += new System.EventHandler(this.re_Click);
            // 
            // name1
            // 
            this.name1.Location = new System.Drawing.Point(229, 72);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(121, 21);
            this.name1.TabIndex = 5;
            // 
            // cout1
            // 
            this.cout1.Location = new System.Drawing.Point(229, 219);
            this.cout1.Name = "cout1";
            this.cout1.Size = new System.Drawing.Size(121, 21);
            this.cout1.TabIndex = 6;
            // 
            // cbx1
            // 
            this.cbx1.FormattingEnabled = true;
            this.cbx1.Location = new System.Drawing.Point(229, 144);
            this.cbx1.Name = "cbx1";
            this.cbx1.Size = new System.Drawing.Size(121, 20);
            this.cbx1.TabIndex = 7;
            // 
            // and
            // 
            this.and.Location = new System.Drawing.Point(74, 319);
            this.and.Multiline = true;
            this.and.Name = "and";
            this.and.Size = new System.Drawing.Size(276, 119);
            this.and.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 450);
            this.Controls.Add(this.and);
            this.Controls.Add(this.cbx1);
            this.Controls.Add(this.cout1);
            this.Controls.Add(this.name1);
            this.Controls.Add(this.re);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.cout);
            this.Controls.Add(this.jongru);
            this.Controls.Add(this.name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label jongru;
        private System.Windows.Forms.Label cout;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.Button re;
        private System.Windows.Forms.TextBox name1;
        private System.Windows.Forms.TextBox cout1;
        private System.Windows.Forms.ComboBox cbx1;
        private System.Windows.Forms.TextBox and;
    }
}

