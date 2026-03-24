namespace _2026_03_15_radiobutton
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
            this.kr = new System.Windows.Forms.RadioButton();
            this.ch = new System.Windows.Forms.RadioButton();
            this.usa = new System.Windows.Forms.RadioButton();
            this.ind = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.male = new System.Windows.Forms.RadioButton();
            this.her = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kr
            // 
            this.kr.AutoSize = true;
            this.kr.Location = new System.Drawing.Point(6, 20);
            this.kr.Name = "kr";
            this.kr.Size = new System.Drawing.Size(47, 16);
            this.kr.TabIndex = 0;
            this.kr.TabStop = true;
            this.kr.Text = "한국";
            this.kr.UseVisualStyleBackColor = true;
            // 
            // ch
            // 
            this.ch.AutoSize = true;
            this.ch.Location = new System.Drawing.Point(102, 20);
            this.ch.Name = "ch";
            this.ch.Size = new System.Drawing.Size(47, 16);
            this.ch.TabIndex = 1;
            this.ch.TabStop = true;
            this.ch.Text = "중국";
            this.ch.UseVisualStyleBackColor = true;
            this.ch.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // usa
            // 
            this.usa.AutoSize = true;
            this.usa.Location = new System.Drawing.Point(6, 64);
            this.usa.Name = "usa";
            this.usa.Size = new System.Drawing.Size(47, 16);
            this.usa.TabIndex = 2;
            this.usa.TabStop = true;
            this.usa.Text = "미국";
            this.usa.UseVisualStyleBackColor = true;
            this.usa.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // ind
            // 
            this.ind.AutoSize = true;
            this.ind.Location = new System.Drawing.Point(102, 64);
            this.ind.Name = "ind";
            this.ind.Size = new System.Drawing.Size(47, 16);
            this.ind.TabIndex = 3;
            this.ind.TabStop = true;
            this.ind.Text = "인도";
            this.ind.UseVisualStyleBackColor = true;
            this.ind.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kr);
            this.groupBox1.Controls.Add(this.ind);
            this.groupBox1.Controls.Add(this.ch);
            this.groupBox1.Controls.Add(this.usa);
            this.groupBox1.Location = new System.Drawing.Point(51, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "국적";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.her);
            this.groupBox2.Controls.Add(this.male);
            this.groupBox2.Location = new System.Drawing.Point(501, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "성별";
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(0, 20);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(47, 16);
            this.male.TabIndex = 1;
            this.male.TabStop = true;
            this.male.Text = "남자";
            this.male.UseVisualStyleBackColor = true;
            this.male.CheckedChanged += new System.EventHandler(this.male_CheckedChanged);
            // 
            // her
            // 
            this.her.AutoSize = true;
            this.her.Location = new System.Drawing.Point(108, 20);
            this.her.Name = "her";
            this.her.Size = new System.Drawing.Size(47, 16);
            this.her.TabIndex = 2;
            this.her.TabStop = true;
            this.her.Text = "여자";
            this.her.UseVisualStyleBackColor = true;
            this.her.CheckedChanged += new System.EventHandler(this.her_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(501, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "제출";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton kr;
        private System.Windows.Forms.RadioButton ch;
        private System.Windows.Forms.RadioButton usa;
        private System.Windows.Forms.RadioButton ind;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton her;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.Button button1;
    }
}

