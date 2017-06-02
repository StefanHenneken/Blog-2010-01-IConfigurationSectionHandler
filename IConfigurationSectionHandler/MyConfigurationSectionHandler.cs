using System.Collections.Generic;
using System.Configuration;
using System.Xml;

namespace MySectionHandler
{
    class MyConfigurationSectionHandler : IConfigurationSectionHandler
    {
        public object Create(object parent, object configContext, XmlNode section)
        {
            List<SectionValue> sectionValueList = new List<SectionValue>();
            XmlNodeList nodeList = section.SelectNodes(@"//value");
            foreach (XmlNode node in nodeList)
            {
                SectionValue sectionValue = new SectionValue();
                sectionValue.Id = XmlConvert.ToInt32(node.SelectSingleNode(@"identifier").InnerText);
                sectionValue.Attribute = node.Attributes["valueAttribute"].Value;
                sectionValue.OldValue = XmlConvert.ToDouble(node.SelectSingleNode(@"settingValue/oldValue").InnerText);
                sectionValue.NewValue = XmlConvert.ToDouble(node.SelectSingleNode(@"settingValue/newValue").InnerText);
                sectionValueList.Add(sectionValue);
            }
            return sectionValueList;            
        }
    }
}
