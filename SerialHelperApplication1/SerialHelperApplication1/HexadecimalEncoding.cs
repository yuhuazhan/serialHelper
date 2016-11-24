using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialHelperApplication1
{
    class HexadecimalEncoding  //主要用途用來轉換
    {
            public static  Encoding enc = Encoding.UTF8;
           ////若不預設編碼，則HexadecimalEncoding預設操作使用UTF8編碼
           // public HexadecimalEncoding()
           // {
           //     enc =
           // }
           // //可以調整編碼格式，再進行轉換
           // public HexadecimalEncoding(Encoding enc1 )
           // {
           //     enc = enc1;
           // }

            public static string ToHexString(string str) //字串轉換成16進制顯示
            {
                
                var sb = new StringBuilder();
                var bytes = Encoding.UTF8.GetBytes(str);
                var hexString = BitConverter.ToString(bytes);
                return hexString.Replace("-", " ");
            }

            public static string FromHexString(string hexString)
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
