using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using EmailReader.Model;
using EmailReader.Model.Operator;
using EmailReader.View;

namespace EmailReader
{
    public partial class FilterManager : Form
    {
        System.Collections.ArrayList arrFilterInfo = new ArrayList();
       
        System.Collections.ArrayList arrFilterInfo1OfCombinedFilter = new ArrayList();
        System.Collections.ArrayList arrFilterInfo2OfCombinedFilter = new ArrayList();
        ArrayList arrFilterInfoOfNotFilter = new ArrayList();

        ArrayList arrTagsOfCmb = new ArrayList(); //all tags in data
        ArrayList arrOperatorOfCmb = new ArrayList();

         public FilterManager()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void showFilterLists()
        {
            cmbFilter1OfCombinedFilter.DataSource = null; //refresh screen
            cmbFilter2OfCombinedFilter.DataSource = null;
            cmbFilterOfNotFilter.DataSource = null;

            arrFilterInfo1OfCombinedFilter.Clear();
            arrFilterInfo2OfCombinedFilter.Clear();
            arrFilterInfoOfNotFilter.Clear();


            dtgFilterList.DataSource = null; //refresh screen
            arrFilterInfo.Clear();

            foreach (IFilter filter in Data.getFilterCollection())
            {
                FilterBriefInfoForCmb fInfo = new FilterBriefInfoForCmb(filter);

                //data of 3 combobox
                arrFilterInfo1OfCombinedFilter.Add(fInfo);
                arrFilterInfo2OfCombinedFilter.Add(fInfo);
                arrFilterInfoOfNotFilter.Add(fInfo);

                //data of grid
                FilterBriefInfo fBInfo = new FilterBriefInfo(filter);
                arrFilterInfo.Add(fBInfo);
             
            }

            cmbFilter1OfCombinedFilter.DataSource = arrFilterInfo1OfCombinedFilter;
            cmbFilter2OfCombinedFilter.DataSource = arrFilterInfo2OfCombinedFilter;
            cmbFilterOfNotFilter.DataSource = arrFilterInfoOfNotFilter;
            dtgFilterList.DataSource = arrFilterInfo;
        }


        private void showOperationList()
        {
            foreach (IOperator ope in Data.getOperatorCollection())
            {
                OperationBriefInfo oInfo = new OperationBriefInfo(ope);
                arrOperatorOfCmb.Add(oInfo);
            }
            cmbOperator.DataSource = arrOperatorOfCmb;
        }

        //show all tags in the combobox
        private void showTagList()
        {
           
            this.arrTagsOfCmb.Clear();
            foreach (ITag tag in Data.getTagCollection())
            {
                TagBriefInfoForCmb tag_brief_info = new TagBriefInfoForCmb(tag);
                this.arrTagsOfCmb.Add(tag_brief_info);
            }
            cmbTag.DataSource = arrTagsOfCmb;
        }

        private void updateScreen()
        {
            showOperationList();
            showTagList();
            showFilterLists();
        
        }

        private void FilterManager_Load(object sender, EventArgs e)
        {
            updateScreen();
        }

     

        private void saveNewFilter()
        {
         
            string resultMsg = "Filter haven't created";

            if (txtFilterName.Text == "")
            {
                MessageBox.Show("You must type filter name", "Warning");
            }
            else
            {
                if (radioBasicFilter.Checked)
                {
                    ITag selected_tag = ((TagBriefInfoForCmb)cmbTag.SelectedItem).getTag();
                    IOperator selected_operator = ((OperationBriefInfo)cmbOperator.SelectedItem).getOperator();

                    //create basic filter
                    IFilter filter = new BasicFilter(txtFilterName.Text, selected_tag, selected_operator, txtValue.Text);
                    Data.insertFilter(filter);
                    resultMsg = "Created 1 basic filter";
                }
                else if (rbCombinedFilter.Checked)
                {
                    //create combined filter
                    if (cmbOperatorOfCombinedFilter.Text == "AND")
                    {

                        IFilter selected_filter1 = ((FilterBriefInfoForCmb)cmbFilter1OfCombinedFilter.SelectedItem).getFilter();
                        IFilter selected_filter2 = ((FilterBriefInfoForCmb)cmbFilter2OfCombinedFilter.SelectedItem).getFilter();

                        IFilter newFilter = new CombinedFilter_AND(txtFilterName.Text, selected_filter1, selected_filter2);
                        Data.insertFilter(newFilter);
                        resultMsg = "Created 1 combined filter";
                    }
                }
                else if (rbNotFilter.Checked)
                {

                    IFilter selected_filter1 = ((FilterBriefInfoForCmb)cmbFilter1OfCombinedFilter.SelectedItem).getFilter();

                    IFilter newFilter = new Filter_NOT(txtFilterName.Text, selected_filter1);
                    Data.insertFilter(newFilter);
                    resultMsg = "Created 1 NOT filter";

                }
            }
            MessageBox.Show(resultMsg);
            updateScreen();
        }



        private void btDelete_Click(object sender, EventArgs e)
        {
            foreach (FilterBriefInfo filterInfo in arrFilterInfo)
            {
                if (filterInfo.IsSelected)
                    Data.removeFilter(filterInfo.Filter);
            }
            updateScreen();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            saveNewFilter();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("chua lam");

        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("chua lam");
        }

    }
}