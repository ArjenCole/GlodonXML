using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace GlodonXML
{

    /**
    public class mcShanghai
    {
        public mcDictionaryWithName ProjectBasicInfo = new mcDictionaryWithName("项目基本信息");
        public mcListWithName<mcDictionaryWithName> FileEditInfo = new mcListWithName<mcDictionaryWithName>();


        public mcProject Project = new mcProject();

        public mcShanghai(XElement pXE)
        {
            IEnumerable<XElement> elements = from ele in pXE.Elements("正文")
                                             select ele;



            foreach (XElement feXE in elements.Elements("项目基本信息"))
            {
                ProjectBasicInfo.ReadXML(feXE);
            }


            FileEditInfo = new mcListWithName<mcDictionaryWithName>(elements.Elements("文件编制属性信息").First());
            
            foreach (XElement feXE in elements.Elements("文件编制属性信息"))
            {
                FileEditInfo.ReadXML(feXE);
            }


        }


    }

    /// <summary>
    /// 整体工程
    /// </summary>
    public class mcProject:mcListWithName<mcSingleProject>
    {
        public mcProject() { Name = "整体工程"; }
    }
    /// <summary>
    /// 单项工程
    /// </summary>
    public class mcSingleProject:mcListWithName<mcSinglePart>
    {
        public mcSingleProject() { Name = "单项工程"; }
    }
    /// <summary>
    /// 单位工程
    /// </summary>
    public class mcSinglePart:mcListWithName<mcNormTable>
    {
        public mcListWithName<mcMeasure> MeasureTable = new mcListWithName<mcMeasure>("措施项目");
        public mcListWithName<mcFees> FeesTable = new mcListWithName<mcFees>("规费项目");
        public mcListWithName<mcDictionaryWithName> TaxTable = new mcListWithName<mcDictionaryWithName>("税金项目");
        public mcListWithName<mcTaxBA> TaxBA = new mcListWithName<mcTaxBA>("税前税后");
        public mcListWithName<mcSummary> Summary = new mcListWithName<mcSummary>("单位工程费用汇总");

        
        public mcSinglePart() { Name = "单位工程"; }

    }

    /// <summary>
    /// 预算书
    /// </summary>
    public class mcNormBook : mcListWithName<mcNormTable>
    {
        public mcNormBook() { Name = "预算书"; }
    }
    /// <summary>
    /// 预算书定额项
    /// </summary>
    public class mcNormTable: mcListWithName<mcNorm>
    {
        public mcNormTable() { Name = "预算书定额项"; }

    }
    /// <summary>
    /// 定额子目项
    /// </summary>
    public class mcNorm:mcListWithName<mcPmmTbale>
    {
        public mcNorm() { Name = "定额子目项"; }

    }
    /// <summary>
    /// 人材机组成
    /// </summary>
    public class mcPmmTbale:mcListWithName<mcPmm>
    {
        public mcPmmTbale() { Name = "人材机组成"; }

    }
    /// <summary>
    /// 人材机明细
    /// </summary>
    public class mcPmm:mcDictionaryWithName
    {
        public mcPmm() { Name = "人材机明细"; }

    }
    /// <summary>
    /// 措施项目明细
    /// </summary>
    public class mcMeasure : mcDictionaryWithName
    {
        public mcMeasure() { Name = "措施项目明细"; }

    }
    /// <summary>
    /// 规费项目明细
    /// </summary>
    public class mcFees:mcListWithName<mcFeesItem>
    {
        public mcFees() { Name = "规费项目明细"; }

    }
    /// <summary>
    /// 规费项目明细子项
    /// </summary>
    public class mcFeesItem:mcDictionaryWithName
    {
        public mcFeesItem() { Name = "规费项目明细子项"; }

    }
    /// <summary>
    /// 税前税后
    /// </summary>
    public class mcTaxBA : mcDictionaryWithName
    {
        public mcTaxBA() { Name = "税前税后"; }
    }
    /// <summary>
    /// 单位工程费用汇总
    /// </summary>
    public class mcSummary : mcDictionaryWithName
    {
        public mcSummary() { Name = "单位工程费用汇总"; }

    }

    **/
}
