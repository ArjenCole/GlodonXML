using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace GlodonXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region 树状结构
        public void Flash_tvConstructProject(mcConstructProject_Norm pCPN)
        {
            mcTreeNode NodeConstructProject = new mcTreeNode(pCPN.Attributes["Name"], 1, 2 , pCPN);//一级节点

            foreach (mcProjectList fePL in pCPN.ProjectList)
            {
                NodeConstructProject.Nodes.Add(buildTreeNode(fePL));
            }

            tvConstructProject.Nodes.Add(NodeConstructProject);
            tvConstructProject.ExpandAll();
        }
        private mcTreeNode buildTreeNode(mcProjectList pPL)
        {
            mcTreeNode reTN = new mcTreeNode(pPL.Attributes["Name"], 1, 2, pPL);

            foreach (mcProjectList fePL in pPL.ProjectList)
            {
                reTN.Nodes.Add(buildTreeNode(fePL));
            }

            return reTN;
        }
        private class mcTreeNode : TreeNode
        {
            public mcProjectList ProjectList = new mcProjectList();
            public mcTreeNode(string text, int imageIndex, int selectedImageIndex)
            {
                ini(text, imageIndex, selectedImageIndex);
            }
            public mcTreeNode(string text, int imageIndex, int selectedImageIndex, mcProjectList pPL)
            {
                ini(text, imageIndex, selectedImageIndex);
                ProjectList = pPL;
            }
            private void ini(string text, int imageIndex, int selectedImageIndex)
            {
                this.Text = text; this.ImageIndex = imageIndex; this.SelectedImageIndex = selectedImageIndex;
            }
        }
        #endregion


        private void tvConstructProject_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            mcTreeNode tTN = (mcTreeNode)e.Node;
            mcProjectList tPL = tTN.ProjectList;
            flash_dgvAttributes(tPL);
            flash_dgvSummary(tPL);
            flash_dgvNormItem(tPL);
            flash_dgvNormTitle(tPL);

            flash_dgvResource(tPL);

        }

        private void flash_All(string pStr)
        {
            //XElement tXE = XElement.Load("杨高南路（高科西路-外环立交）1标段 - 1.SGTYS");
            //XElement tXE = XElement.Load("市政工程.XML");
            //XElement tXE = XElement.Load("学府路东延.xml");
            //XElement tXE = XElement.Load("徐州市汉源大道快速化改造工程.xml");

            
            XElement tXE = XElement.Load(pStr);
            mcConstructProject_Norm mCPN = new mcConstructProject_Norm(tXE);

            Flash_tvConstructProject(mCPN);
        }

        private void flash_dgvAttributes(mcProjectList pPL)
        {
            dgvAttributes.Rows.Clear();

            dgvAttributes.Rows.Add(pPL.Attributes.Count());
            int i = 0;
            foreach (KeyValuePair<string, string> feKVP in pPL.Attributes)
            {
                dgvAttributes[0, i].Value = feKVP.Key;
                dgvAttributes[1, i].Value = feKVP.Value;
                i++;
            }
        }
        private void flash_dgvSummary(mcProjectList pPL)
        {
            if (pPL.Summary.Count() == 0) return;
            dgvSummary.Columns.Clear();
            dgvSummary.Columns.Add("CostID", "CostID");
            dgvSummary.Rows.Clear();
            dgvSummary.Rows.Add(pPL.Summary.Count());


            int i = 0;
            foreach(mcSummaryItem feSI in pPL.Summary)
            {
                foreach (KeyValuePair<string, string> feKVP in feSI.Attributes)
                {
                    if (!dgvSummary.Columns.Contains(feKVP.Key))
                    {
                        dgvSummary.Columns.Add(feKVP.Key, feKVP.Key);
                    }
                    dgvSummary.Rows[i].Cells[feKVP.Key].Value = feKVP.Value;
                }
                i++;
            }
        }
        private void flash_dgvNormItem(mcProjectList pPL)
        {
            dgvNormItem.Columns.Clear();
            dgvNormItem.Columns.Add("NormItem", "NormItem");
            dgvNormItem.Rows.Clear();
            int tRowCount = 0;
            foreach (var fe in pPL.NormTable)
                tRowCount = tRowCount + fe.NormItem.Count();
            if (tRowCount == 0) return;
            dgvNormItem.Rows.Add(tRowCount);

            int i = 0;
            foreach(mcNormItemTitle feNTIT in pPL.NormTable)
            {
                foreach (mcNormItem feNTI in feNTIT.NormItem)
                {
                    foreach (KeyValuePair<string, string> feKVP in feNTI.Attributes)
                    {
                        if (!dgvNormItem.Columns.Contains(feKVP.Key))
                            dgvNormItem.Columns.Add(feKVP.Key, feKVP.Key);
                        dgvNormItem.Rows[i].Cells[feKVP.Key].Value = feKVP.Value;
                    }
                    i++;
                }
            }
        }
        private void flash_dgvNormTitle(mcProjectList pPL)
        {
            dgvNormTitle.Columns.Clear();
            dgvNormTitle.Columns.Add("NormItem", "NormItem");
            dgvNormTitle.Rows.Clear();
            int tRowCount = 0;
            foreach (var fe in pPL.NormTable)
                tRowCount = tRowCount + fe.NormItem.Count();
            if (tRowCount == 0) return;
            dgvNormTitle.Rows.Add(tRowCount);

            int i = 0;
            foreach (mcNormItemTitle feNTIT in pPL.NormTable)
            {
                double tDouble = 0;
                foreach (mcNormItem feNTI in feNTIT.NormItem)
                {
                    foreach (KeyValuePair<string,string> feKVP in feNTI.Attributes)
                    {
                        if (feKVP.Key == "Total")
                            tDouble += Convert.ToDouble(feKVP.Value);
                    }
                }
                foreach (KeyValuePair<string, string> feKVP in feNTIT.Attributes)
                {
                    if (!dgvNormTitle.Columns.Contains(feKVP.Key))
                        dgvNormTitle.Columns.Add(feKVP.Key, feKVP.Key);
                    dgvNormTitle.Rows[i].Cells[feKVP.Key].Value = feKVP.Value;
                }
                if (!dgvNormTitle.Columns.Contains("Total"))
                    dgvNormTitle.Columns.Add("Total", "Total");
                dgvNormTitle.Rows[i].Cells["Total"].Value = tDouble;
                i++;
            }
        }

        private void flash_dgvResource(mcProjectList pPL)
        {
            dgvResource.Columns.Clear();
            dgvResource.Columns.Add("ResourceItem", "ResourceItem");
            dgvResource.Rows.Clear();
            int tRowCount = pPL.Resource.Count();
            if (tRowCount == 0) return;
            dgvResource.Rows.Add(tRowCount);

            int i = 0;
            foreach (mcResourceItem feRI in pPL.Resource)
            {
                foreach (KeyValuePair<string, string> feKVP in feRI.Attributes)
                {
                    if (!dgvResource.Columns.Contains(feKVP.Key))
                    {
                        dgvResource.Columns.Add(feKVP.Key, feKVP.Key);
                    }
                    dgvResource.Rows[i].Cells[feKVP.Key].Value = feKVP.Value;
                }
                i++;
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var t = ((DataGridView)sender).CurrentCell.Value;
            if (t != null) { mscFunction.CopyToClipBoard(t.ToString()); }
        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            string tStr = mscFunction.getOpenPath();
            //flash_All("徐州市汉源大道快速化改造工程.xml");
            flash_All(tStr);
        }


    }
}
