using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialPortTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 加载串口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //获取本机所有串口名
            string[] serialPortName = SerialPort.GetPortNames();
            if (serialPortName.Length<=0)
            {
                MessageBox.Show("未检测到可用的串口资源", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //填充串口列表
            foreach (var portName in serialPortName)
            {
                this.comboBoxMeasure.Items.Add(portName);
                this.comboBoxSwitch.Items.Add(portName);
            }
            //显示串口默认值
            this.comboBoxMeasure.SelectedIndex = 0;
            this.comboBoxSwitch.SelectedIndex = 0;
        }

        /// <summary>
        /// 开启微欧仪串口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStartSerialPortMeasure_Click(object sender, EventArgs e)
        {
            try
            {
                this.serialPortMeasure.PortName = this.comboBoxMeasure.SelectedItem.ToString();
                if (!this.serialPortMeasure.IsOpen)
                {
                    this.serialPortMeasure.Open();
                }
                this.buttonStartSerialPortMeasure.Enabled = false;

            }
            catch (Exception)
            {

                throw;
            }
            
        }

        /// <summary>
        /// 关闭微欧仪串口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStopSerialPortMeasure_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.serialPortMeasure.IsOpen)
                {
                    this.serialPortMeasure.Close();
                }

                this.buttonStartSerialPortMeasure.Enabled = true;
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        /// <summary>
        /// 开启多路转换器串口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStartSerialPortSwitch_Click(object sender, EventArgs e)
        {
            try
            {
                this.serialPortSwitch.PortName = this.comboBoxSwitch.SelectedItem.ToString();

                if (!this.serialPortSwitch.IsOpen)
                {
                    this.serialPortSwitch.Open();
                }
                this.buttonStartSerialPortSwitch.Enabled = false;
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        /// <summary>
        /// 关闭多路转换器串口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStopSerialPortSwitch_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.serialPortSwitch.IsOpen)
                {
                    this.serialPortSwitch.Close();
                }
                this.buttonStartSerialPortSwitch.Enabled = true;
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        /// <summary>
        /// 发送多路转换器命令
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            this.serialPortSwitch.Write(this.textBoxSendSwich.Text);
        }

        /// <summary>
        /// 发送微欧仪命令
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            this.serialPortMeasure.Write(this.textBoxSendMeasure.Text);
        }

        /// <summary>
        /// 多路转换器接收数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void serialPortSwitch_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.textBoxRecSwitch.AppendText(this.serialPortSwitch.ReadExisting());
        }

        /// <summary>
        /// 微欧仪接收数据事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void serialPortMeasure_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.textBoxRecMeasure.AppendText(this.serialPortMeasure.ReadExisting());
        }
    }
}
