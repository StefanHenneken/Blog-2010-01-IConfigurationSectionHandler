using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace MySectionHandler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ReadSection_OnClick(object sender, EventArgs e)
        {
            List<SectionValue> sectionValueList = ConfigurationManager.GetSection("mySection") as List<SectionValue>;
            listViewSection.Items.Clear();
            foreach (SectionValue sectionValue in sectionValueList)
            {
                ListViewItem listItem = new ListViewItem(sectionValue.Id.ToString());
                listItem.SubItems.Add(sectionValue.Attribute);
                listItem.SubItems.Add(sectionValue.OldValue.ToString());
                listItem.SubItems.Add(sectionValue.NewValue.ToString());
                listViewSection.Items.Add(listItem);
            }
        }
    }
}
