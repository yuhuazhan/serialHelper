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
namespace SerialHelperApplication1
{
    public partial class SerialHelper_Form : Form
    {
        private string[] baudRate = {"1200","2400","4800","9600","14400","19200","38400","43000","57600","76800","115200","128000",
                                "230400","256000","460800","921600","1382400","自定義" };
        private string[] dataBits = { "5","6","7","8"};
        Boolean AutoScroll_state = false; //預設不啟用自動下拉
        enum Language_type{type_tw=0,type_cn,type_en}; //定義語言狀態類型
        Language_type Ltype =  Language_type.type_tw;

        delegate void Display(String str); //(委派)定義函式指標型態
      
        private Encoding enc = Encoding.GetEncoding("big5"); //使用big5編碼
        ResourceManager LocRM_cn = new ResourceManager("SerialHelperApplication1.WinFormStrings_cn", typeof(SerialHelper_Form).Assembly);//簡體資源管器
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
                serialPort1.Encoding = Encoding.GetEncoding("big5");
                                              //資料終端機就緒 (DTR) 通常是在 XON/XOFF 軟體信號交換和傳送 (RTS/CTS) 硬體信號交換，與數據機通訊的傳送/清除要求期間啟用。
                try
                {
                    
                    serialPort1.Open(); //開啟串口，只有這行會出錯
                    serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
                    pictureBox1.Load(System.Environment.CurrentDirectory + "/picture/open.png");
                    mangeCom_btn.Text = "close";
                }
                catch(Exception err)
                {
                    MessageBox.Show(err.Message); //顯示開啟錯物的對應訊息
                }
                 
            }
            else
            {
                pictureBox1.Load(System.Environment.CurrentDirectory + "/picture/close.png");
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
                Display d = new Display(updateRecv_textb); //(委派指向的函數地址)(給函數指標設定指向函數的地址)
                this.Invoke(d, new object[] { enc.GetString(buffer) }); //執行委派，調用函數指標(指定回調函數)
            }
        }

        private void updateRecv_textb(String str)
        {
            recv_textb.Text += str;
        }

        private void recv_textb_TextChanged(object sender, EventArgs e)
        {
            if (AutoScroll_state) //如果使能自動下拉
            {
                recv_textb.SelectionStart = recv_textb.Text.Length;
                recv_textb.ScrollToCaret();
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

        private void clearRecvtxtb_btn_Click(object sender, EventArgs e)
        {
            recv_textb.Text = "";//清除接收顯示區域資料
        }

        private void versionMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SenData_btn_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                serialPort1.Write(singleSendText_rtxtb.Text+serialPort1.NewLine);
                      
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
    }
  
}

