﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Resources;
namespace SerialHelperApplication1
{
    public partial class SerialHelper_Form : Form
    {
        private string[] baudRate = {"1200","2400","4800","9600","14400","19200","38400","43000","57600","76800","115200","128000",
                                "230400","256000","460800","921600","1382400","自定義" };
        private string[] dataBits = { "5","6","7","8"};
        public SerialHelper_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //新增介面中有關Serial相關的屬性
            //如波特率 9600........等。
            pictureBox1.Load(System.Environment.CurrentDirectory+"/picture/close.png");
            IntializeUIForSerial();
       
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.ScrollToCaret();
        }
        //初始化和串列通訊有關的UI
        private void IntializeUIForSerial()
        {
            //combobox 增加可使用的波特律屬性
            baudSelect_comb.Items.AddRange(baudRate);
           //combobox 取得所有停止位的屬性
            foreach (string s in Enum.GetNames(typeof(StopBits)))
            {
                stopBitsSelect_comb.Items.Add(s);
            }
            //combobox 取得所校驗位的所有屬性
            foreach (string s in Enum.GetNames(typeof(Parity)))
            {
                checkBitSelect_comb.Items.Add(s);                  
            }
            //combobox 取得所有工作管理員當中的串口號         
            comSelect_comb.Items.AddRange(SerialPort.GetPortNames());
            dataBitsSelect_comb.Items.AddRange(dataBits);
            
        }
        //開啟串口或關閉串口按鈕回調函數
        private void mangeCom_btn_Click(object sender, EventArgs e)
        {
            if(!serialPort1.IsOpen) //如果串口關閉 
            {
                //設定串口相關參數
                serialPort1.PortName = comSelect_comb.Text;
                serialPort1.BaudRate = int.Parse(baudSelect_comb.Text);
                serialPort1.DataBits = int.Parse(dataBitsSelect_comb.Text);
                serialPort1.StopBits = (StopBits)(Enum.Parse(typeof(StopBits),stopBitsSelect_comb.Text));
                serialPort1.Parity = (Parity)(Enum.Parse(typeof(Parity), checkBitSelect_comb.Text));
                try
                {
                    serialPort1.Open(); //開啟串口，只有這行會出錯
                    serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
                    pictureBox1.Load(System.Environment.CurrentDirectory + "/picture/open.png");
                    mangeCom_btn.Text = "關閉串口";
                }
                catch(Exception err)
                {
                    MessageBox.Show(err.Message); //顯示開啟錯物的對應訊息
                }
                 
            }
            else
            {
                pictureBox1.Load(System.Environment.CurrentDirectory + "/picture/close.png");
                mangeCom_btn.Text = "開啟串口";
                serialPort1.Close();//關閉串口               
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            throw new NotImplementedException();
            if ((sender as SerialPort).BytesToRead > 0)
            {
                Byte[] buffer = new Byte[1024];
                Int32 length = (sender as SerialPort).Read(buffer, 0, buffer.Length);
                Array.Resize(ref buffer, length); //將buffer大小調整成收到數據的大小
            }
        }
        //menu 選擇語系->簡體  回調函數 還沒完整支援
        private void 简体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResourceManager LocRM = new ResourceManager("SerialHelperApplication1.WinFormStrings_cn", typeof(SerialHelper_Form).Assembly);
            serialNumber_lbl.Text = LocRM.GetString("serialNumber_lbl_txt");
            baudRate_lbl.Text = LocRM.GetString("baudRate_lbl_txt");
            dataLen_lbl.Text =  LocRM.GetString("dataLen_lbl_txt");
            stopBits_lbl.Text = LocRM.GetString("stopBits_lbl_txt");
            checkBit_lbl.Text = LocRM.GetString("checkBit_lbl_txt");
            groupBox1.Text = LocRM.GetString("groupBox1_txt");
            groupBox2.Text = LocRM.GetString("groupBox2_txt");
            groupBox3.Text = LocRM.GetString("groupBox3_txt");
            groupBox4.Text = LocRM.GetString("groupBox4_txt");
        }
    }
  
}
