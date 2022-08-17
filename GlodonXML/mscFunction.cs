using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GlodonXML
{
    public static class mscFunction
    {
        public static void CopyToClipBoard(string pCopyStr)
        {
            Clipboard.SetDataObject(pCopyStr);
        }

        public static string getOpenPath(string pFilter = "*.xml|*.xml", string pPath = "")
        {
            using (OpenFileDialog OFD = new OpenFileDialog())
            {
                OFD.Filter = pFilter;
                //OFD.InitialDirectory = pPath == "" ? Environment.GetFolderPath(Environment.SpecialFolder.Desktop) : pPath;
                if (pPath != "") OFD.InitialDirectory = pPath;
                if (OFD.ShowDialog() == DialogResult.OK)
                    return OFD.FileName;
                else
                    return string.Empty;
            }
        }
    }



}
