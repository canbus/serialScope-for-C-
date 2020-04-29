namespace SerialScope
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.cbBps = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbScale = new System.Windows.Forms.ComboBox();
            this.btnClean = new System.Windows.Forms.Button();
            this.cbCh0 = new System.Windows.Forms.CheckBox();
            this.cbch1 = new System.Windows.Forms.CheckBox();
            this.cbch2 = new System.Windows.Forms.CheckBox();
            this.cbch3 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbPort
            // 
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(13, 13);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(96, 26);
            this.cbPort.TabIndex = 0;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(369, 5);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(98, 39);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // cbBps
            // 
            this.cbBps.FormattingEnabled = true;
            this.cbBps.Location = new System.Drawing.Point(115, 13);
            this.cbBps.Name = "cbBps";
            this.cbBps.Size = new System.Drawing.Size(91, 26);
            this.cbBps.TabIndex = 2;
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(1, 94);
            this.chart1.Name = "chart1";
            this.chart1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(594, 324);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // cbScale
            // 
            this.cbScale.FormattingEnabled = true;
            this.cbScale.Location = new System.Drawing.Point(221, 12);
            this.cbScale.Name = "cbScale";
            this.cbScale.Size = new System.Drawing.Size(77, 26);
            this.cbScale.TabIndex = 4;
            this.cbScale.SelectedIndexChanged += new System.EventHandler(this.cbScale_SelectedIndexChanged);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(473, 5);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(98, 39);
            this.btnClean.TabIndex = 5;
            this.btnClean.Text = "Clear";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // cbCh0
            // 
            this.cbCh0.AutoSize = true;
            this.cbCh0.Checked = true;
            this.cbCh0.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCh0.Location = new System.Drawing.Point(13, 58);
            this.cbCh0.Name = "cbCh0";
            this.cbCh0.Size = new System.Drawing.Size(61, 22);
            this.cbCh0.TabIndex = 7;
            this.cbCh0.Text = "ch0";
            this.cbCh0.UseVisualStyleBackColor = true;
            // 
            // cbch1
            // 
            this.cbch1.AutoSize = true;
            this.cbch1.Location = new System.Drawing.Point(91, 58);
            this.cbch1.Name = "cbch1";
            this.cbch1.Size = new System.Drawing.Size(61, 22);
            this.cbch1.TabIndex = 8;
            this.cbch1.Text = "ch1";
            this.cbch1.UseVisualStyleBackColor = true;
            // 
            // cbch2
            // 
            this.cbch2.AutoSize = true;
            this.cbch2.Location = new System.Drawing.Point(168, 57);
            this.cbch2.Name = "cbch2";
            this.cbch2.Size = new System.Drawing.Size(61, 22);
            this.cbch2.TabIndex = 9;
            this.cbch2.Text = "ch2";
            this.cbch2.UseVisualStyleBackColor = true;
            // 
            // cbch3
            // 
            this.cbch3.AutoSize = true;
            this.cbch3.Location = new System.Drawing.Point(247, 57);
            this.cbch3.Name = "cbch3";
            this.cbch3.Size = new System.Drawing.Size(61, 22);
            this.cbch3.TabIndex = 10;
            this.cbch3.Text = "ch3";
            this.cbch3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 416);
            this.Controls.Add(this.cbch3);
            this.Controls.Add(this.cbch2);
            this.Controls.Add(this.cbch1);
            this.Controls.Add(this.cbCh0);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.cbScale);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.cbBps);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.cbPort);
            this.Name = "Form1";
            this.Text = "SerialScope";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ComboBox cbBps;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox cbScale;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.CheckBox cbCh0;
        private System.Windows.Forms.CheckBox cbch1;
        private System.Windows.Forms.CheckBox cbch2;
        private System.Windows.Forms.CheckBox cbch3;
    }
}

