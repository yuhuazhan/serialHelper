using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//用途:用於操作 字串 <=>16進制的字串，兩者相互之間轉換的操作
//Start <->53 74 61 72 74 
namespace SerialHelperApplication1
{
    class HexadecimalEncoding  //主要用途用來轉換
    {
        private  Encoding enc { get; set; } //屬性用於設定編碼

        //若不預設編碼，則HexadecimalEncoding預設操作使用UTF8編碼
        public HexadecimalEncoding()//建構子函數
        {
            enc = Encoding.UTF8;
         }
        //可以調整編碼格式，再進行轉換
        public HexadecimalEncoding(Encoding enc1)//建構子函數
        {
            enc = enc1;
        }

         public string ToHexString(string str) //字串轉換成16進制顯示
         {
                
                var sb = new StringBuilder();
                var bytes = Encoding.UTF8.GetBytes(str);
                var hexString = BitConverter.ToString(bytes);
                return hexString.Replace("-", " ");
         }
          //從16進制字串轉換為字串
          public string FromHexString(string hexString)
          {
                if (hexString == "") return "";
                hexString = hexString.Replace(" ", "");
                if (hexString.Length % 2 != 0)
                throw new ArgumentException("hexString must have an even length", "hexString");
                var bytes = new byte[hexString.Length / 2];
                  string currentHex;
                for (int i = 0; i < bytes.Length; i++)
                {
                    currentHex = hexString.Substring(i * 2, 2);
                    bytes[i] = Convert.ToByte(currentHex, 16);
                }
               
                 return enc.GetString(bytes);
           }
           
    }
}
