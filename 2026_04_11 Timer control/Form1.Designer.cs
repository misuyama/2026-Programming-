namespace _2026_04_11_Timer_control
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.디지털ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.끝내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.디지털ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.아날로그ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.date = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.멈추기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.디지털ToolStripMenuItem,
            this.끝내기ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 디지털ToolStripMenuItem
            // 
            this.디지털ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.디지털ToolStripMenuItem1,
            this.아날로그ToolStripMenuItem,
            this.멈추기ToolStripMenuItem});
            this.디지털ToolStripMenuItem.Name = "디지털ToolStripMenuItem";
            this.디지털ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.디지털ToolStripMenuItem.Text = "시계";
            // 
            // 끝내기ToolStripMenuItem
            // 
            this.끝내기ToolStripMenuItem.Name = "끝내기ToolStripMenuItem";
            this.끝내기ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.끝내기ToolStripMenuItem.Text = "끝내기";
            this.끝내기ToolStripMenuItem.Click += new System.EventHandler(this.끝내기ToolStripMenuItem_Click);
            // 
            // 디지털ToolStripMenuItem1
            // 
            this.디지털ToolStripMenuItem1.Name = "디지털ToolStripMenuItem1";
            this.디지털ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.디지털ToolStripMenuItem1.Text = "디지털";
            this.디지털ToolStripMenuItem1.Click += new System.EventHandler(this.디지털ToolStripMenuItem1_Click);
            // 
            // 아날로그ToolStripMenuItem
            // 
            this.아날로그ToolStripMenuItem.Name = "아날로그ToolStripMenuItem";
            this.아날로그ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.아날로그ToolStripMenuItem.Text = "아날로그";
            this.아날로그ToolStripMenuItem.Click += new System.EventHandler(this.아날로그ToolStripMenuItem_Click);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(121, 128);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(0, 12);
            this.date.TabIndex = 1;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(121, 234);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(0, 12);
            this.time.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // 멈추기ToolStripMenuItem
            // 
            this.멈추기ToolStripMenuItem.Name = "멈추기ToolStripMenuItem";
            this.멈추기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.멈추기ToolStripMenuItem.Text = "멈추기";
            this.멈추기ToolStripMenuItem.Click += new System.EventHandler(this.멈추기ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.time);
            this.Controls.Add(this.date);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "시계 컨트롤";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 디지털ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 디지털ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 아날로그ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 끝내기ToolStripMenuItem;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem 멈추기ToolStripMenuItem;
    }
}

