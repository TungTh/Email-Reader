using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EmailReader.Model;

namespace EmailReader
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void tagToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        void demoHienCacDefaultTag()
        {
            IEnumerator<IEmail> arrEmail = Data.getEmailCollection().GetEnumerator();
            arrEmail.MoveNext();
            IEmail email = arrEmail.Current;

            foreach (ITag tag in Data.getTagCollection())
            {
                if (tag.isDefaultTag == true)
                {
                    string tagValue = tag.getEmailTag(email);
                    MessageBox.Show(tag.Name+" = "+ tagValue);
                }
            }

        }

        void demoHienCacTag()
        {
            IEnumerator<IEmail> arrEmail = Data.getEmailCollection().GetEnumerator();
            arrEmail.MoveNext();
            IEmail email = arrEmail.Current;

            foreach (ITag tag in Data.getTagCollection())
            {
                string tagValue = tag.getEmailTag(email);
                MessageBox.Show(tagValue);
            }
        }

        void demoTaoBasicFilterVaApplyFilter()
        {
            //lay tag
            IEnumerator<ITag> arrTag = Data.getTagCollection().GetEnumerator();
            arrTag.MoveNext();
            ITag fromTag = arrTag.Current;

            //tao operator
            IOperator strContainOper= new StringContainsOperator();

            IFilter basicFilter = new BasicFilter("From John", fromTag, strContainOper, "9");

            //thu apply cac filter cho email

            foreach (IEmail e in Data.getEmailCollection())
            {
                if (basicFilter.apply(e))
                    MessageBox.Show("tim thay roi:"+fromTag.getEmailTag(e));
            }
        }

        void demoTaoNotFilter()
        {
            //lay tag
            IEnumerator<ITag> arrTag = Data.getTagCollection().GetEnumerator();
            arrTag.MoveNext();
            ITag fromTag = arrTag.Current;

            //tao operator
            IOperator strContainOper = new StringContainsOperator();

            AbstractFilter basicFilter = new BasicFilter("From 9", fromTag, strContainOper, "9");
            IFilter notFilter = new Filter_NOT("Not from 9", basicFilter);
            //thu apply cac filter cho email

            foreach (IEmail e in Data.getEmailCollection())
            {
                if (notFilter.apply(e))
                    MessageBox.Show("tim thay roi:" + fromTag.getEmailTag(e));
            }
        }

        void demoTaoANDFilterVaApplyFilter()
        {
            //lay tag
            IEnumerator<ITag> arrTag = Data.getTagCollection().GetEnumerator();
            arrTag.MoveNext();
            ITag fromTag = arrTag.Current;
            arrTag.MoveNext();
            ITag toTag = arrTag.Current;            

            //tao operator
            IOperator strContainOper = new StringContainsOperator();
            
            IFilter filterForm5 = new BasicFilter("From 5", fromTag, strContainOper, "5");
            IFilter filterTo2 = new BasicFilter("To 2", toTag, strContainOper, "2");
            AbstractFilter filterFrom5AndTo2 = new CombinedFilter_AND("From 5 and to 2", filterForm5, filterTo2);

            //thu apply cac filter cho email

            foreach (IEmail e in Data.getEmailCollection())
            {
                if (filterFrom5AndTo2.apply(e))
                    MessageBox.Show("tim thay roi:" + fromTag.getEmailTag(e) +toTag.getEmailTag(e));
            }
        }


        void demoTaoORFilterVaApplyFilter()
        {
            //lay tag
            IEnumerator<ITag> arrTag = Data.getTagCollection().GetEnumerator();
            arrTag.MoveNext();
            ITag fromTag = arrTag.Current;
            arrTag.MoveNext();
            ITag toTag = arrTag.Current;

            //tao operator
            IOperator strContainOper = new StringContainsOperator();

            IFilter filterForm5 = new BasicFilter("From 5", fromTag, strContainOper, "5");
            IFilter filterTo2 = new BasicFilter("To 2", toTag, strContainOper, "2");
            AbstractFilter filterFrom5OrTo2 = new CombinedFilter_OR("From 5 or to 2", filterForm5, filterTo2);

            //thu apply cac filter cho email

            foreach (IEmail e in Data.getEmailCollection())
            {
                if (filterFrom5OrTo2.apply(e))
                    MessageBox.Show("tim thay roi:" + fromTag.getEmailTag(e) + toTag.getEmailTag(e));
            }
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

        }
      private void MainScreen_Load(object sender, EventArgs e)
      {
        Testing.MainTest test= new EmailReader.Testing.MainTest();
            //demoHienCacDefaultTag();
            //demoTaoBasicFilterVaApplyFilter();
            demoTaoORFilterVaApplyFilter();
		}
    }
}