﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialHelperApplication1
{
    class HexadecimalEncoding
    {
      
            public static string ToHexString(string str)
            {
                if (str == "") return "";
                var sb = new StringBuilder();
                var bytes = Encoding.UTF8.GetBytes(str);
                foreach (var t in bytes)
                {
                    sb.Append(t.ToString("X2") + " ");
                }

                return sb.ToString(); // returns: "48656C6C6F20776F726C64" for "Hello world"
            }

            public static string FromHexString(string hexString)
            {
                if (hexString == "") return "";
                hexString = hexString.Replace(" ", "");
                var bytes = new byte[hexString.Length / 2];
                for (var i = 0; i < bytes.Length; i++)
                {
                
                    bytes[i] = Convert.ToByte(hexString.Substring(i*2,2), 16);
                
                }

                return Encoding.UTF8.GetString(bytes); // returns: "Hello world" for "48656C6C6F20776F726C64"
            }
        
    }
}
