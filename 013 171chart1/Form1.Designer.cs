namespace _013_171chart1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnOneChartArea = new System.Windows.Forms.Button();
            this.BtnTwoChartArea = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(169, 12);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(457, 362);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // btnOneChartArea
            // 
            this.btnOneChartArea.Font = new System.Drawing.Font("한컴 훈민정음 세로쓰기", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOneChartArea.Location = new System.Drawing.Point(169, 398);
            this.btnOneChartArea.Name = "btnOneChartArea";
            this.btnOneChartArea.Size = new System.Drawing.Size(117, 23);
            this.btnOneChartArea.TabIndex = 1;
            this.btnOneChartArea.Text = "합쳐서 그리기";
            this.btnOneChartArea.UseVisualStyleBackColor = true;
            this.btnOneChartArea.Click += new System.EventHandler(this.btnOneChartArea_Click);
            // 
            // BtnTwoChartArea
            // 
            this.BtnTwoChartArea.Font = new System.Drawing.Font("한컴 훈민정음 세로쓰기", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnTwoChartArea.Location = new System.Drawing.Point(514, 398);
            this.BtnTwoChartArea.Name = "BtnTwoChartArea";
            this.BtnTwoChartArea.Size = new System.Drawing.Size(112, 23);
            this.BtnTwoChartArea.TabIndex = 2;
            this.BtnTwoChartArea.Text = "쪼개서 그리기";
            this.BtnTwoChartArea.UseVisualStyleBackColor = true;
            this.BtnTwoChartArea.Click += new System.EventHandler(this.BtnTwoChartArea_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnTwoChartArea);
            this.Controls.Add(this.btnOneChartArea);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "치트";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnOneChartArea;
        private System.Windows.Forms.Button BtnTwoChartArea;
    }
}

