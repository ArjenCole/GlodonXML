using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace GlodonXML
{
    public class mcListWithName<T>
    {
        public string Name = "";

        public Dictionary<string, string> Attributes = new Dictionary<string, string>();
        public Dictionary<string, string> Elements = new Dictionary<string, string>();

        public string ListName = "";
        public List<T> List = new List<T>();


        public mcListWithName()
        {
            
        }
        public mcListWithName(string pStr)
        {
            Name = pStr;
        }
        public mcListWithName(XElement pXE)
        {
            Name = pXE.Name.ToString();
            foreach (XElement feXE in pXE.Elements())
            {
                if (feXE.HasElements)
                {
                    foreach (XElement feXE1 in feXE.Elements())
                    {
                        T tmpT = default(T);

                        tmpT=((miReadXML<T>)tmpT).ReadXML(feXE1);
                        List.Add((T)tmpT);
                    }
                }
                else
                {
                    Elements.Add(feXE.Name.ToString(), feXE.Value);
                }
            }
        }


        public void AddAttributes(string pStr1, string pStr2)
        {
            Attributes.Add(pStr1, pStr2);
        }
        public void AddElement(string pStr1, string pStr2)
        {
            Elements.Add(pStr1, pStr2);
        }
        public void Add(T pT)
        {
            List.Add(pT);
        }
    }
}
