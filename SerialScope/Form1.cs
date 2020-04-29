using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.Win32;

namespace SerialScope
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            RegistryKey keyCom = Registry.LocalMachine.OpenSubKey("Hardware\\DeviceMap\\SerialComm");
            if (keyCom != null)
            {
                string[] sSubKeys = keyCom.GetValueNames();
                cbPort.Items.Clear();
                foreach (string sName in sSubKeys)
                {
                    string sValue = (string)keyCom.GetValue(sName);
                    cbPort.Items.Add(sValue);
                }
                if (cbPort.Items.Count > 0)
                    cbPort.SelectedIndex = 0;
            }
            cbBps.Items.Add("9600");
            cbBps.Items.Add("115200");
            cbBps.SelectedIndex = 1;
            cbScale.Items.Add("1000");
            cbScale.Items.Add("100");
            cbScale.Items.Add("10");
            cbScale.Items.Add("1");
            cbScale.Items.Add("0.1");
            cbScale.Items.Add("0.01");
            cbScale.Items.Add("0.001");
            cbScale.SelectedIndex = 6;
            initChart();
        }
        bool isOpened = false;//串口状态标志
        private void btnOpen_Click(object sender, EventArgs e)
        {

            if (!isOpened)
            {
                serialPort.PortName = cbPort.Text;
                serialPort.BaudRate = int.Parse(cbBps.Text);
                try
                {
                    serialPort.Open();     //打开串口
                    btnOpen.Text = "关闭串口";
                    cbPort.Enabled = false;//关闭使能
                    isOpened = true;
                    serialPort.DataReceived += new SerialDataReceivedEventHandler(post_DataReceived);//串口接收处理函数
                }
                catch
                {
                    MessageBox.Show("串口打开失败！");
                }
            }
            else
            {
                try
                {
                    serialPort.Close();     //关闭串口
                    btnOpen.Text = "打开串口";
                    cbPort.Enabled = true;//打开使能
                    isOpened = false;
                }
                catch
                {
                    MessageBox.Show("串口关闭失败！");
                }
            }
            
        }
        private void post_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //string bufs = serialPort.ReadExisting();//字符串方式读
            byte[] bufs = new byte[10];
            int len = 0;
            //serialPort.ReadTimeout = 500;
            while (len < 10)
            {
                bufs[len++] = (byte)serialPort.ReadByte();
                if (bufs[0] != 0xFF)
                    return;
            }
            byte sum=0;
            for (int i = 0; i < 9; i++)
                sum += bufs[i];
            if (sum != bufs[9])
               return;

            Action action_updataUI = () =>
            {
                updateUI(bufs, 9);
            };
            Invoke(action_updataUI);
        }

        private void updateUI(byte[] bufs, int p)
        {   
            int ch0Val = BitConverter.ToInt16(bufs, 1);
            int ch1Val = BitConverter.ToInt16(bufs, 1+2);
            int ch2Val = BitConverter.ToInt16(bufs, 1+4);
            int ch3Val = BitConverter.ToInt16(bufs, 1+6);

            if (cbCh0.Checked)
            {
                cbCh0.Text = ((float)(ch0Val * scale)).ToString("F3");
                chartCh0.Points.Add(ch0Val * scale);
            }
            if (cbch1.Checked)
            {
                cbch1.Text = ((float)(ch1Val * scale)).ToString("F3");
                chartCh1.Points.Add(ch1Val * scale);
            }
            if (cbch2.Checked)
            {
                cbch2.Text = ((float)(ch2Val * scale)).ToString("F3");
                chartCh2.Points.Add(ch2Val * scale);
            }
            if (cbch3.Checked)
            {
                cbch3.Text = ((float)(ch3Val * scale)).ToString("F3");
                chartCh3.Points.Add(ch3Val * scale);
            }
          
        }
        Series chartCh0, chartCh1, chartCh2, chartCh3;
        private void initChart()
        {
            chart1.Series.Clear();
            chartCh0 = new Series("ch0");
            chartCh1 = new Series("ch1");
            chartCh2 = new Series("ch2");
            chartCh3 = new Series("ch3");
            chartCh0.ChartType = SeriesChartType.FastLine;
            chartCh1.ChartType = SeriesChartType.FastLine;
            chartCh2.ChartType = SeriesChartType.FastLine;
            chartCh3.ChartType = SeriesChartType.FastLine;
            chart1.Series.Add(chartCh0);
            chart1.Series.Add(chartCh1);
            chart1.Series.Add(chartCh2);
            chart1.Series.Add(chartCh3);
            chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
        }
        float scale = 1;
        private void cbScale_SelectedIndexChanged(object sender, EventArgs e)
        {
            scale = float.Parse(cbScale.Text);
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            initChart();
        }

        
    }
}
