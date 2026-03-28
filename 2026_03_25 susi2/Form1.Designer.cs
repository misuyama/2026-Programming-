namespace _2026_03_25_susi2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.cleararea = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.TextBox();
            this.name1 = new System.Windows.Forms.TextBox();
            this.middle = new System.Windows.Forms.TextBox();
            this.rast = new System.Windows.Forms.TextBox();
            this.sugje = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "학번";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "이름";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "중간고사";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "기말고사";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "과제";
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(50, 325);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 5;
            this.clear.Text = "계산";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // cleararea
            // 
            this.cleararea.Location = new System.Drawing.Point(176, 325);
            this.cleararea.Name = "cleararea";
            this.cleararea.Size = new System.Drawing.Size(75, 23);
            this.cleararea.TabIndex = 6;
            this.cleararea.Text = "초기화";
            this.cleararea.UseVisualStyleBackColor = true;
            this.cleararea.Click += new System.EventHandler(this.cleararea_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(50, 382);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(201, 126);
            this.result.TabIndex = 7;
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(138, 44);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(100, 21);
            this.number.TabIndex = 8;
            // 
            // name1
            // 
            this.name1.Location = new System.Drawing.Point(138, 96);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(100, 21);
            this.name1.TabIndex = 9;
            // 
            // middle
            // 
            this.middle.Location = new System.Drawing.Point(138, 151);
            this.middle.Name = "middle";
            this.middle.Size = new System.Drawing.Size(100, 21);
            this.middle.TabIndex = 10;
            // 
            // rast
            // 
            this.rast.Location = new System.Drawing.Point(138, 206);
            this.rast.Name = "rast";
            this.rast.Size = new System.Drawing.Size(100, 21);
            this.rast.TabIndex = 11;
            // 
            // sugje
            // 
            this.sugje.Location = new System.Drawing.Point(138, 255);
            this.sugje.Name = "sugje";
            this.sugje.Size = new System.Drawing.Size(100, 21);
            this.sugje.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 532);
            this.Controls.Add(this.sugje);
            this.Controls.Add(this.rast);
            this.Controls.Add(this.middle);
            this.Controls.Add(this.name1);
            this.Controls.Add(this.number);
            this.Controls.Add(this.result);
            this.Controls.Add(this.cleararea);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "학점계산기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button cleararea;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.TextBox name1;
        private System.Windows.Forms.TextBox middle;
        private System.Windows.Forms.TextBox rast;
        private System.Windows.Forms.TextBox sugje;
    }
}

