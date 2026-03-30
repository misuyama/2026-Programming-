namespace _2026_03_29_Chart_2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.onepic = new System.Windows.Forms.Button();
            this.twopic = new System.Windows.Forms.Button();
            this.ch1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.ch1)).BeginInit();
            this.SuspendLayout();
            // 
            // onepic
            // 
            this.onepic.Location = new System.Drawing.Point(214, 319);
            this.onepic.Name = "onepic";
            this.onepic.Size = new System.Drawing.Size(106, 23);
            this.onepic.TabIndex = 0;
            this.onepic.Text = "하나로 그리기";
            this.onepic.UseVisualStyleBackColor = true;
            this.onepic.Click += new System.EventHandler(this.onepic_Click);
            // 
            // twopic
            // 
            this.twopic.Location = new System.Drawing.Point(433, 319);
            this.twopic.Name = "twopic";
            this.twopic.Size = new System.Drawing.Size(117, 23);
            this.twopic.TabIndex = 1;
            this.twopic.Text = "쪼개서 그리기";
            this.twopic.UseVisualStyleBackColor = true;
            this.twopic.Click += new System.EventHandler(this.twopic_Click);
            // 
            // ch1
            // 
            chartArea3.Name = "ChartArea1";
            this.ch1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.ch1.Legends.Add(legend3);
            this.ch1.Location = new System.Drawing.Point(214, 12);
            this.ch1.Name = "ch1";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "영어";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "국어";
            this.ch1.Series.Add(series5);
            this.ch1.Series.Add(series6);
            this.ch1.Size = new System.Drawing.Size(336, 300);
            this.ch1.TabIndex = 2;
            this.ch1.Text = "chart1";
            this.ch1.Click += new System.EventHandler(this.ch1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ch1);
            this.Controls.Add(this.twopic);
            this.Controls.Add(this.onepic);
            this.Name = "Form1";
            this.Text = "차트";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ch1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button onepic;
        private System.Windows.Forms.Button twopic;
        private System.Windows.Forms.DataVisualization.Charting.Chart ch1;
    }
}

