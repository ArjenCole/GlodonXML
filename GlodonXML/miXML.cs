using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace GlodonXML
{
    public interface miReadXML<T>
    {
        T ReadXML(XElement pXE);
    }

    public static class mscReadXML
    {
        public static mcDictionaryWithName ReadXML(XElement pXE)
        {
            mcDictionaryWithName reDWN = new mcDictionaryWithName();
            foreach (XElement feXE in pXE.Elements())
            {
                reDWN.Dictionary.Add(feXE.Name.ToString(), feXE.Value);
            }
            return reDWN;
        }
    }


}
