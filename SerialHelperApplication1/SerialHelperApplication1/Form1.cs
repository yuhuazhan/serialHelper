using System;
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
using System.Reflection;
namespace SerialHelperApplication1
{
    public partial class SerialHelper_Form : Form
    {
      
        string version = "Version 1.05";
        private string[] baudRate = {"1200","2400","4800","9600","14400","19200","38400","43000","57600","76800","115200","128000",
                                "230400","256000","460800","921600","1382400","自定義" };
        private string[] dataBits = { "5","6","7","8"};
        Boolean AutoScroll_state = false; //預設不啟用自動下拉
        enum Language_type{type_tw=0,type_cn,type_en}; //定義語言狀態類型
        enum display_formate {formate_string = 0,formate_hex };//定義接收顯示框顯示方式
        enum PacketEndType { EndTypeNone = 0 , EndTypeNewLineReturn };//發送封包結尾

        Language_type Ltype = Language_type.type_tw;//預設繁體中文顯示
        display_formate dispFormate = display_formate.formate_string; //預設字串顯示
        PacketEndType Endtype = PacketEndType.EndTypeNone;//預設發送封包結尾不加/r/n
        delegate void Display(string str); //(委派)定義函式指標型態
        public Encoding enc = Encoding.UTF8; //使用utf-8編碼
        private HexadecimalEncoding hEncod = new HexadecimalEncoding(Encoding.UTF8);
        private UILanguage ul1 = new UILanguage(0);
        ResourceManager LocRM_cn = new ResourceManager("SerialHelperApplication1.WinFormStrings_cn", typeof(SerialHelper_Form).Assembly);//簡體資源管器
       
        public SerialHelper_Form()
        {
            InitializeComponent();
         

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //新增介面中有關Serial相關的屬性
            //如波特率 9600........等。
            pictureBox1.Image = (Image)LocRM_cn.GetObject("close");
            IntializeUIForSerial();
            comPort_tmr.Interval = 300; // 300ms偵測一次是否有com
            comPort_tmr.Start();//開啟timer 
            foreach(var s in ul1.showXML())
            {
                MessageBox.Show(s);
            }
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
                serialPort1.DtrEnable = true; // 表示啟用 Data Terminal Ready (DTR)；否則為 false。預設為 false。 
                                              //資料終端機就緒 (DTR) 通常是在 XON/XOFF 軟體信號交換和傳送 (RTS/CTS) 硬體信號交換，與數據機通訊的傳送/清除要求期間啟用。
                //serialPort1.RtsEnable = true;
                serialPort1.Encoding = Encoding.UTF8;
                                              
                try
                {
                    
                    serialPort1.Open(); //開啟串口，只有這行會出錯
                    serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
                    pictureBox1.Image = (Image)LocRM_cn.GetObject("open");

                    mangeCom_btn.Text = "close";
                }
                catch(Exception err)
                {
                    MessageBox.Show(err.Message); //顯示開啟錯物的對應訊息
                }
                 
            }
            else
            {
                pictureBox1.Image = (Image)LocRM_cn.GetObject("close");
                mangeCom_btn.Text = "open";
                serialPort1.Close();//關閉串口               
            }
        }
        //不屬於主執行緒的執行緒，需要透過委派的方式由主執行緒上
        //的函數才能更新主執行緒上的UI
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if ((sender as SerialPort).BytesToRead > 0)
            {
                Byte[] buffer = new Byte[serialPort1.BytesToRead];
                serialPort1.Read(buffer, 0, buffer.Length);
                Display d = new Display(updaterecvText_rtxtb); //(委派指向的函數地址)(給函數指標設定指向函數的地址)           
                this.Invoke(d, new object[] { enc.GetString(buffer)}); //執行委派，調用函數指標(指定回調函數)
            }
        }
        //被委派的函式,向ｕｉ更新資料
        private void updaterecvText_rtxtb(string str )
        {
            if(dispFormate == display_formate.formate_string)
            {
                recvText_rtxtb.Text += str ;
            }
                
            else
            {
                
                recvText_rtxtb.Text += hEncod.ToHexString(str);
            }
        }

        private void recvText_rtxtb_TextChanged(object sender, EventArgs e)
        {
            if (AutoScroll_state) //如果使能自動下拉
            {
                recvText_rtxtb.SelectionStart = recvText_rtxtb.Text.Length;
                recvText_rtxtb.ScrollToCaret();
                
            }
        }
        //menu 選擇語系->簡體  回調函數 還沒完整支援
        private void 简体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            serialNumber_lbl.Text = LocRM_cn.GetString("serialNumber_lbl_txt");
            baudRate_lbl.Text = LocRM_cn.GetString("baudRate_lbl_txt");
            dataLen_lbl.Text =  LocRM_cn.GetString("dataLen_lbl_txt");
            stopBits_lbl.Text = LocRM_cn.GetString("stopBits_lbl_txt");
            checkBit_lbl.Text = LocRM_cn.GetString("checkBit_lbl_txt");
            groupBox1.Text = LocRM_cn.GetString("groupBox1_txt");
            groupBox2.Text = LocRM_cn.GetString("groupBox2_txt");
            groupBox3.Text = LocRM_cn.GetString("groupBox3_txt");
            groupBox4.Text = LocRM_cn.GetString("groupBox4_txt");

         

        }

        private void AutoScroll_chb_CheckedChanged(object sender, EventArgs e)
        {
            AutoScroll_state = !AutoScroll_state;
        }
        //清除接收顯示區域資料
        private void clearRecvtxtb_btn_Click(object sender, EventArgs e)
        {
            recvText_rtxtb.Text = "";
        }
        //版本顯示
        private void versionMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(version);
        }
        //發送資料按鈕事件
        private void SenData_btn_Click(object sender, EventArgs e)
        {
            string tmp = singleSendText_rtxtb.Text;
            if (serialPort1.IsOpen)//串口是否開啟
            {       
                switch (Endtype)
                {
                    case PacketEndType.EndTypeNewLineReturn:
                        tmp = tmp + serialPort1.NewLine;
                        break;
                    case PacketEndType.EndTypeNone:
                        break;

                }
                if (singleSendText_rtxtb.Text != "")
                    serialPort1.Write(tmp);
                else
                    MessageBox.Show("發送區沒有資料");        
            }
            else
            {
                switch(Ltype)
                {
                    case Language_type.type_tw:
                        MessageBox.Show("串口尚未開啟");
                        break;
                    case Language_type.type_cn:
                        MessageBox.Show("串口尚未开启");
                        break;
                    case Language_type.type_en:
                        break;
                }        
            }
        }

       
        //接收格式選用16進制顯示或字串顯示
        private void recv_formate_chb_CheckedChanged(object sender, EventArgs e)
        {
            if (recv_formate_chb.Checked)//選擇16進制發送，打勾
            {
                dispFormate = display_formate.formate_hex;
                recvText_rtxtb.Text = hEncod.ToHexString(recvText_rtxtb.Text);
            }
            else
            {
                dispFormate = display_formate.formate_string;
                //MessageBox.Show(recvText_rtxtb.Text);
                recvText_rtxtb.Text = hEncod.FromHexString(recvText_rtxtb.Text);
                //MessageBox.Show(HexadecimalEncoding.FromHexString(recvText_rtxtb.Text));
            }
        }
        //發送封包格式是否使用特殊格式
        private void sendEndtype_chb_CheckedChanged(object sender, EventArgs e)
        {
          if(sendEndtype_chb.Checked) //選擇發送新行
          {
                Endtype = PacketEndType.EndTypeNewLineReturn;
          }
          else
          {
                Endtype = PacketEndType.EndTypeNone;
          }
        }
        //300ms定時偵測是否有新的usb串口裝置插入
        private void comPort_tmr_Tick(object sender, EventArgs e)
        {
            comSelect_comb.Items.Clear();
            comSelect_comb.Items.AddRange(SerialPort.GetPortNames());
        }

        private void timeSend_chb_CheckedChanged(object sender, EventArgs e)
        {
            Int32 tmpint = decimal.ToInt32(timeSend_numup.Value);//取的使用者設定的interval
          

           
                if (timeSend_chb.Checked)
                {
                     if (decimal.ToInt32(timeSend_numup.Value) > 0)
                　    {
                          if (singleSendText_rtxtb.Text != "")
                          { 
                             timerSend.Interval = tmpint;//設定timer,中斷時間
                             timerSend.Start(); //開啟定時發送timer
                          }
                          else
                         {
                            MessageBox.Show("發送區為空，不能定時發送");
                            timeSend_chb.CheckState = CheckState.Unchecked;
                    }
                      }    
                　    else
                　    {
                        MessageBox.Show("定時發送不能為零");
                        timeSend_chb.CheckState = CheckState.Unchecked;
                        timerSend.Stop();
                      }　
                }
                else
                {
                     timerSend.Stop(); //關閉定時發送timer 
                }
        }
        //定時發送
        private void timerSend_Tick(object sender, EventArgs e)
        {      
            SenData_btn.PerformClick();//叫發送按鈕工作
        }

     
    }
  
}

