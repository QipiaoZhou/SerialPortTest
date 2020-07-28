namespace SerialPortTest
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxMeasure = new System.Windows.Forms.ComboBox();
            this.comboBoxSwitch = new System.Windows.Forms.ComboBox();
            this.buttonStartSerialPortMeasure = new System.Windows.Forms.Button();
            this.buttonStopSerialPortMeasure = new System.Windows.Forms.Button();
            this.buttonStartSerialPortSwitch = new System.Windows.Forms.Button();
            this.buttonStopSerialPortSwitch = new System.Windows.Forms.Button();
            this.serialPortMeasure = new System.IO.Ports.SerialPort(this.components);
            this.serialPortSwitch = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxRecSwitch = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.textBoxSendSwich = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBoxRecMeasure = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.textBoxSendMeasure = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "微欧仪串口:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "多路切换串口:";
            // 
            // comboBoxMeasure
            // 
            this.comboBoxMeasure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMeasure.FormattingEnabled = true;
            this.comboBoxMeasure.Location = new System.Drawing.Point(142, 35);
            this.comboBoxMeasure.Name = "comboBoxMeasure";
            this.comboBoxMeasure.Size = new System.Drawing.Size(121, 20);
            this.comboBoxMeasure.TabIndex = 2;
            // 
            // comboBoxSwitch
            // 
            this.comboBoxSwitch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSwitch.FormattingEnabled = true;
            this.comboBoxSwitch.Location = new System.Drawing.Point(135, 29);
            this.comboBoxSwitch.Name = "comboBoxSwitch";
            this.comboBoxSwitch.Size = new System.Drawing.Size(121, 20);
            this.comboBoxSwitch.TabIndex = 2;
            // 
            // buttonStartSerialPortMeasure
            // 
            this.buttonStartSerialPortMeasure.Location = new System.Drawing.Point(55, 73);
            this.buttonStartSerialPortMeasure.Name = "buttonStartSerialPortMeasure";
            this.buttonStartSerialPortMeasure.Size = new System.Drawing.Size(75, 23);
            this.buttonStartSerialPortMeasure.TabIndex = 3;
            this.buttonStartSerialPortMeasure.Text = "打开";
            this.buttonStartSerialPortMeasure.UseVisualStyleBackColor = true;
            this.buttonStartSerialPortMeasure.Click += new System.EventHandler(this.buttonStartSerialPortMeasure_Click);
            // 
            // buttonStopSerialPortMeasure
            // 
            this.buttonStopSerialPortMeasure.Location = new System.Drawing.Point(172, 73);
            this.buttonStopSerialPortMeasure.Name = "buttonStopSerialPortMeasure";
            this.buttonStopSerialPortMeasure.Size = new System.Drawing.Size(75, 23);
            this.buttonStopSerialPortMeasure.TabIndex = 3;
            this.buttonStopSerialPortMeasure.Text = "关闭";
            this.buttonStopSerialPortMeasure.UseVisualStyleBackColor = true;
            this.buttonStopSerialPortMeasure.Click += new System.EventHandler(this.buttonStopSerialPortMeasure_Click);
            // 
            // buttonStartSerialPortSwitch
            // 
            this.buttonStartSerialPortSwitch.Location = new System.Drawing.Point(48, 69);
            this.buttonStartSerialPortSwitch.Name = "buttonStartSerialPortSwitch";
            this.buttonStartSerialPortSwitch.Size = new System.Drawing.Size(75, 23);
            this.buttonStartSerialPortSwitch.TabIndex = 3;
            this.buttonStartSerialPortSwitch.Text = "打开";
            this.buttonStartSerialPortSwitch.UseVisualStyleBackColor = true;
            this.buttonStartSerialPortSwitch.Click += new System.EventHandler(this.buttonStartSerialPortSwitch_Click);
            // 
            // buttonStopSerialPortSwitch
            // 
            this.buttonStopSerialPortSwitch.Location = new System.Drawing.Point(165, 69);
            this.buttonStopSerialPortSwitch.Name = "buttonStopSerialPortSwitch";
            this.buttonStopSerialPortSwitch.Size = new System.Drawing.Size(75, 23);
            this.buttonStopSerialPortSwitch.TabIndex = 3;
            this.buttonStopSerialPortSwitch.Text = "关闭";
            this.buttonStopSerialPortSwitch.UseVisualStyleBackColor = true;
            this.buttonStopSerialPortSwitch.Click += new System.EventHandler(this.buttonStopSerialPortSwitch_Click);
            // 
            // serialPortMeasure
            // 
            this.serialPortMeasure.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortMeasure_DataReceived);
            // 
            // serialPortSwitch
            // 
            this.serialPortSwitch.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortSwitch_DataReceived);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxMeasure);
            this.groupBox1.Controls.Add(this.buttonStopSerialPortMeasure);
            this.groupBox1.Controls.Add(this.buttonStartSerialPortMeasure);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 118);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "微欧仪";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBoxSwitch);
            this.groupBox2.Controls.Add(this.buttonStopSerialPortSwitch);
            this.groupBox2.Controls.Add(this.buttonStartSerialPortSwitch);
            this.groupBox2.Location = new System.Drawing.Point(12, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 114);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "多路切换";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Location = new System.Drawing.Point(17, 281);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(297, 79);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "发送设置";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(171, 37);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 16);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.Text = "字节";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(48, 37);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "字符";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton3);
            this.groupBox4.Controls.Add(this.radioButton4);
            this.groupBox4.Location = new System.Drawing.Point(17, 371);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(297, 79);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "接收设置";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(171, 37);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(47, 16);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.Text = "字节";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(48, 37);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(47, 16);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "字符";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxRecSwitch);
            this.groupBox5.Location = new System.Drawing.Point(331, 22);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(301, 259);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "多路转换数据接收区";
            // 
            // textBoxRecSwitch
            // 
            this.textBoxRecSwitch.Location = new System.Drawing.Point(12, 20);
            this.textBoxRecSwitch.Multiline = true;
            this.textBoxRecSwitch.Name = "textBoxRecSwitch";
            this.textBoxRecSwitch.Size = new System.Drawing.Size(274, 233);
            this.textBoxRecSwitch.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button5);
            this.groupBox6.Controls.Add(this.textBoxSendSwich);
            this.groupBox6.Location = new System.Drawing.Point(331, 297);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(301, 153);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "多路转换数据发送区";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(95, 108);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 28);
            this.button5.TabIndex = 1;
            this.button5.Text = "发送";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBoxSendSwich
            // 
            this.textBoxSendSwich.Location = new System.Drawing.Point(12, 20);
            this.textBoxSendSwich.Multiline = true;
            this.textBoxSendSwich.Name = "textBoxSendSwich";
            this.textBoxSendSwich.Size = new System.Drawing.Size(274, 63);
            this.textBoxSendSwich.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBoxRecMeasure);
            this.groupBox7.Location = new System.Drawing.Point(656, 22);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(301, 259);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "微欧仪数据接收区";
            // 
            // textBoxRecMeasure
            // 
            this.textBoxRecMeasure.Location = new System.Drawing.Point(12, 20);
            this.textBoxRecMeasure.Multiline = true;
            this.textBoxRecMeasure.Name = "textBoxRecMeasure";
            this.textBoxRecMeasure.Size = new System.Drawing.Size(274, 233);
            this.textBoxRecMeasure.TabIndex = 0;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.button6);
            this.groupBox8.Controls.Add(this.textBoxSendMeasure);
            this.groupBox8.Location = new System.Drawing.Point(656, 297);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(301, 153);
            this.groupBox8.TabIndex = 8;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "微欧仪数据发送区";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(95, 108);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(121, 28);
            this.button6.TabIndex = 1;
            this.button6.Text = "发送";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBoxSendMeasure
            // 
            this.textBoxSendMeasure.Location = new System.Drawing.Point(12, 20);
            this.textBoxSendMeasure.Multiline = true;
            this.textBoxSendMeasure.Name = "textBoxSendMeasure";
            this.textBoxSendMeasure.Size = new System.Drawing.Size(274, 63);
            this.textBoxSendMeasure.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 462);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxMeasure;
        private System.Windows.Forms.ComboBox comboBoxSwitch;
        private System.Windows.Forms.Button buttonStartSerialPortMeasure;
        private System.Windows.Forms.Button buttonStopSerialPortMeasure;
        private System.Windows.Forms.Button buttonStartSerialPortSwitch;
        private System.Windows.Forms.Button buttonStopSerialPortSwitch;
        private System.IO.Ports.SerialPort serialPortMeasure;
        private System.IO.Ports.SerialPort serialPortSwitch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBoxRecSwitch;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBoxSendSwich;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox textBoxRecMeasure;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBoxSendMeasure;
    }
}

