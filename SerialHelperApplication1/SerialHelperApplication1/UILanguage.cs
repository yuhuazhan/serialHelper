using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace SerialHelperApplication1
{
    class UILanguage
    {
       
        public UILanguage(int index)
        {

        }
        public List<string> showXML()
        {
            XDocument xd;
            xd = XDocument.Load("Language.xml");
            var s = xd.Root.Element("UILanguage").Elements("Language");
            List<string> s1 = new List<string>();
            foreach (var a in s)
            {
                string attr = a.Attribute("id").Value;      
                s1.Add(a.Attribute("id").Value);
            }
            return s1;
        }
    }
}
