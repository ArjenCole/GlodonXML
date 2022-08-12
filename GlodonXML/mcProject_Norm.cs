using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace GlodonXML
{
    public class mcConstructProject_Norm : mcProjectList
    {
        public mcConstructProject_Norm(XElement pXE)
        {
            Name = pXE.Name.ToString();
            foreach (var feAtt in pXE.Attributes())
            {
                Attributes.Add(feAtt.Name.ToString(), feAtt.Value);
            }
            IEnumerable<XElement> ConstructProject = from ele in pXE.Elements("ProjectList")
                                                     select ele;
            var t = ConstructProject.First();
            ProjectList.Add(new mcProjectList(ConstructProject.First()));
        }

    }

    
    

    public class mcProjectList:mcItem
    {
        public List<mcSummaryItem> Summary=new List<mcSummaryItem>();
        public List<mcNormItemTitle> NormTable=new List<mcNormItemTitle>();
        public List<mcMeasureTitle> MeasureTable = new List<mcMeasureTitle>();
        public List<mcResourceItem> Resource = new List<mcResourceItem>();
        public IList<mcProjectList> ProjectList = new List<mcProjectList>();


        public mcProjectList()
        {

        }

        public mcProjectList(XElement pXE)
        {
            Name = pXE.Name.ToString();
            foreach (var feAtt in pXE.Attributes())
            {
                Attributes.Add(feAtt.Name.ToString(), feAtt.Value);
            }

            IEnumerable<XElement> projectList = from ele in pXE.Elements("ProjectList")
                                                select ele;

            foreach (XElement feXE in projectList)
            {
                IEnumerable<XElement> Son = from ele in feXE.Elements("ProjectList")
                                            select ele;
                if (Son.Count() > 0)//如果有名为ProjectList的子项，进入递归
                {
                    ProjectList.Add(new mcProjectList(feXE));
                }
                else//如果没有名为ProjectList的子项,读入数据跳出递归
                {
                    mcProjectList tPL = new mcProjectList();

                    tPL.Name = feXE.Name.ToString();
                    foreach (var feAtt in feXE.Attributes())
                    {
                        tPL.Attributes.Add(feAtt.Name.ToString(), feAtt.Value);
                    }

                    IEnumerable<XElement> XEsummary = from ele in feXE.Elements("Summary")
                                                      select ele;
                    foreach (XElement feXE1 in XEsummary.Elements())
                        tPL.Summary.Add(new mcSummaryItem(feXE1));


                    IEnumerable<XElement> XEnormTable = from ele in feXE.Elements("NormTable")
                                                        select ele;
                    foreach (XElement feXE1 in XEnormTable.Elements("NormItemTitle"))
                        tPL.NormTable.Add(new mcNormItemTitle(feXE1));
                    //如果NormTable下没有NormItemTitle这一级直接是NormItem，自动补一个NormItemTitle，然后把NormItem列入这个NormItemTitle下
                    if (XEnormTable.Elements("NormItemTitle").Count() == 0 && XEnormTable.Elements().Count() != 0) 
                    {
                        tPL.NormTable.Add(new mcNormItemTitle());

                        foreach (XElement feXE1 in XEnormTable.Elements("NormItem"))
                            tPL.NormTable[0].NormItem.Add(new mcNormItem(feXE1));
                    }






                    IEnumerable<XElement> XEmeasureTable = from ele in feXE.Elements("MeasureTable")
                                                        select ele;
                    foreach (XElement feXE1 in XEmeasureTable.Elements())
                        tPL.MeasureTable.Add(new mcMeasureTitle(feXE1));


                    IEnumerable<XElement> XEresource = from ele in feXE.Elements("Resource")
                                                           select ele;
                    foreach (XElement feXE1 in XEresource.Elements())
                        tPL.Resource.Add(new mcResourceItem(feXE1));


                    ProjectList.Add(tPL);
                }
            }

        }

    }

    public class mcSummaryItem:mcItem
    {
        public mcSummaryItem(XElement pXE)
        {
            Name = "SummaryItem";
            foreach(XAttribute feAtt in pXE.Attributes())
            {
                Attributes.Add(feAtt.Name.ToString(), feAtt.Value);
            }
        }
    }

    public class mcNormItemTitle : mcItem
    {
        public List<mcNormItem> NormItem = new List<mcNormItem>();
        public mcNormItemTitle()
        {
            Name = "NormItemTitle";
            Attributes.Add("NormItemTitleID", "1");
            Attributes.Add("Code", "");
            Attributes.Add("Name", "自动补全");
            Attributes.Add("Remark", "");
        }

        public mcNormItemTitle(XElement pXE)
        {
            Name = "NormItemTitle";
            foreach (XAttribute feAtt in pXE.Attributes())
            {
                Attributes.Add(feAtt.Name.ToString(), feAtt.Value);
            }

            IEnumerable<XElement> XEnormItemTitle = from ele in pXE.Elements("NormItem")
                                                select ele;
            foreach(XElement feXE in XEnormItemTitle)
            {
                NormItem.Add(new mcNormItem(feXE));
            }


        }
    }


    public class mcMeasureTitle:mcItem
    {
        public List<mcMeasureItem> MeasureItem = new List<mcMeasureItem>();
        public mcMeasureTitle(XElement pXE)
        {
            Name = "MeasureTitle";
            foreach (XAttribute feAtt in pXE.Attributes())
            {
                Attributes.Add(feAtt.Name.ToString(), feAtt.Value);
            }

            IEnumerable<XElement> XEmeasureTitle = from ele in pXE.Elements("MeasureTitle")
                                                    select ele;
            foreach (XElement feXE in XEmeasureTitle)
            {
                MeasureItem.Add(new mcMeasureItem(feXE));
            }
        }
    }
    public class mcMeasureItem : mcItem
    {
        public List<mcNormItem> MeasureNorm = new List<mcNormItem>();
        public mcMeasureItem(XElement pXE)
        {
            Name = "MeasureItem";
            foreach (XAttribute feAtt in pXE.Attributes())
            {
                Attributes.Add(feAtt.Name.ToString(), feAtt.Value);
            }
            IEnumerable<XElement> XEmeasureItem = from ele in pXE.Elements("MeasureItem")
                                                   select ele;
            foreach (XElement feXE in XEmeasureItem)
            {
                MeasureNorm.Add(new mcNormItem(feXE));
            }
        }
    }


    public class mcResourceItem:mcItem
    {
        public List<mcItem> ResourceUsage = new List<mcItem>();
        public mcResourceItem(XElement pXE)
        {
            Name = "ResourceItem";
            foreach (XAttribute feAtt in pXE.Attributes())
            {
                Attributes.Add(feAtt.Name.ToString(), feAtt.Value);
            }

            IEnumerable<XElement> XEresource = from ele in pXE.Elements("ResourceItem")
                                                   select ele;
            foreach (XElement feXE in XEresource)
            {
                ResourceUsage.Add(new mcItem(feXE));
            }

        }
    }





    public class mcNormItem : mcItem
    {
        public List<mcItem> NormResUsage = new List<mcItem>();
        public mcNormItem(XElement pXE)
        {
            Name = "NormItem";
            foreach (XAttribute feAtt in pXE.Attributes())
            {
                Attributes.Add(feAtt.Name.ToString(), feAtt.Value);
            }
            IEnumerable<XElement> XEnormResUsageItem = from ele in pXE.Elements("NormResUsageItem")
                                                    select ele;
            foreach (XElement feXE in XEnormResUsageItem)
            {
                NormResUsage.Add(new mcItem(feXE));
            }
        }
    }

    public class mcItem
    {
        public string Name = "";
        public Dictionary<string, string> Attributes = new Dictionary<string, string>();

        public mcItem()
        {

        }

        public mcItem(XElement pXE)
        {
            Name = pXE.Name.ToString();
            foreach(var feAtt in pXE.Attributes())
            {
                Attributes.Add(feAtt.Name.ToString(), feAtt.Value);
            }
        }
    }
}
