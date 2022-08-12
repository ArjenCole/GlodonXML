using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace GlodonXML
{
    public class mcDictionaryWithName
    {
        public string Name = "";
        public Dictionary<string, string> Dictionary = new Dictionary<string, string>();

        public mcDictionaryWithName()
        {

        }

        
        
        public mcDictionaryWithName(string pStr)
        {
            Name = pStr;
        }
        public void ReadXML(XElement pXE)
        {
            foreach (XElement feXE in pXE.Elements())
            {
                Dictionary.Add(feXE.Name.ToString(), feXE.Value);
            }
        }

        public void ReadXML(XElement pXE , string pName)
        {
            Name = pName;

            IEnumerable<XElement> elements = from ele in pXE.Elements(pName)
                                             select ele;
            foreach (XElement feXE in elements)
            {

            }
            
        }
    }
}
