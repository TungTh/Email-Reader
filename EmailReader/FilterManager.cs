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
using EmailReader.Model.Command;

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
    static ActionHandler actionHandlerOfFilterManager = new ActionHandler();

    enum EditModes { CreateNew = 1, EditOld = 2 };
    EditModes editMode;
    IFilter editedFilter; //filter is being edited

    public FilterManager()
    {
      InitializeComponent();
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
      controlUndoButtons();
    }

    private void FilterManager_Load(object sender, EventArgs e)
    {
      Data.ActionHandler = actionHandlerOfFilterManager;
      updateScreen();
      editMode = EditModes.CreateNew;
    }

    private void createCombinedFilter()
    {
      //create combined filter
      IFilter selected_filter1 = ((FilterBriefInfoForCmb)cmbFilter1OfCombinedFilter.SelectedItem).getFilter();
      IFilter selected_filter2 = ((FilterBriefInfoForCmb)cmbFilter2OfCombinedFilter.SelectedItem).getFilter();

      IFilter newFilter;

      if (cmbOperatorOfCombinedFilter.Text == "AND")
      {
        newFilter = new CombinedFilter_AND(txtFilterName.Text, selected_filter1, selected_filter2);
      }
      else
        newFilter = new CombinedFilter_OR(txtFilterName.Text, selected_filter1, selected_filter2);
      Data.insertFilter(newFilter);
    }

    private void save()
    {

      string resultMsg = "Filter haven't created";

      if (txtFilterName.Text == "")
      {
        MessageBox.Show("You must type filter name", "Warning");
      }
      else
      {
        if (editMode == EditModes.CreateNew) //save new filter
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
            resultMsg = "Created 1 combined filter";
            createCombinedFilter();
          }
          else if (rbNotFilter.Checked)
          {

            IFilter selected_filter1 = ((FilterBriefInfoForCmb)cmbFilterOfNotFilter.SelectedItem).getFilter();

            IFilter newFilter = new Filter_NOT(txtFilterName.Text, selected_filter1);
            Data.insertFilter(newFilter);
            resultMsg = "Created 1 NOT filter";

          }
        }
        else if (editMode == EditModes.EditOld) //save edited filter 
        {
          if (rbNotFilter.Checked)
          {

            IFilter selected_filter1 = ((FilterBriefInfoForCmb)cmbFilterOfNotFilter.SelectedItem).getFilter();
            ((Filter_NOT)editedFilter).edit(selected_filter1);
            resultMsg = "Updated 1 NOT filter: " + editedFilter.Name;

          }
          else if (radioBasicFilter.Checked)
          {
            ITag selected_tag = ((TagBriefInfoForCmb)cmbTag.SelectedItem).getTag();
            IOperator selected_operator = ((OperationBriefInfo)cmbOperator.SelectedItem).getOperator();
            ((BasicFilter)editedFilter).edit(txtFilterName.Text, selected_tag, selected_operator, txtValue.Text);
            resultMsg = "Updated 1 Basic filter: " + editedFilter.Name;
          }
          else if (rbCombinedFilter.Checked)
          {
            Data.removeFilter(editedFilter);
            createCombinedFilter();
            resultMsg = "Updated 1 Combined filter: " + editedFilter.Name;
          }
        }
      }
      MessageBox.Show(resultMsg);
      updateScreen();
    }

    bool noFilterIsSelected()
    {
      bool ret = true;
      foreach (FilterBriefInfo filterInfo in arrFilterInfo)
      {
        if (filterInfo.IsSelected)
        {
          ret = false;
          break;
        }
      }
      return ret;
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
      if (noFilterIsSelected())
        editMode = EditModes.CreateNew;
      save();
    }

    private void btnUndo_Click(object sender, EventArgs e)
    {
      Data.ActionHandler.undo();

      updateScreen();
    }

    private void controlUndoButtons()
    {
      btnUndo.Enabled = Data.ActionHandler.CanUndo;
      btnRedo.Enabled = Data.ActionHandler.CanRedo;
    }

    private void btnRedo_Click(object sender, EventArgs e)
    {
      Data.ActionHandler.redo();

      updateScreen();
    }

    private void btnEditFilter_Click(object sender, EventArgs e)
    {
      foreach (FilterBriefInfo filterInfo in arrFilterInfo)
      {
        if (filterInfo.IsSelected)
        {
          this.editedFilter = filterInfo.Filter;
          editMode = EditModes.EditOld;
          this.txtFilterName.Text = filterInfo.Name;

          if (filterInfo.Filter.GetType() == typeof(Filter_NOT))
          {
            //load selected NOT FILTER
            rbNotFilter.Checked = true;

            //show details of this filter
            foreach (FilterBriefInfoForCmb o in arrFilterInfoOfNotFilter)
            {
              if (o.getFilter().Name == ((Filter_NOT)filterInfo.Filter).Filter.Name)
                cmbFilterOfNotFilter.SelectedItem = o;
            }
          }
          else if (filterInfo.Filter.GetType() == typeof(BasicFilter))
          {
            radioBasicFilter.Checked = true;
            //show details of this filter5
            foreach (TagBriefInfoForCmb o in arrTagsOfCmb)
            {
              if (o.Name == ((BasicFilter)editedFilter).Tag.Name)
              {
                cmbTag.SelectedItem = o;
              }
            }
            foreach (OperationBriefInfo o in arrOperatorOfCmb)
            {
              if (o.Name == ((BasicFilter)editedFilter).Operator.Name)
              {
                cmbOperator.SelectedItem = o;
              }
            }
            txtValue.Text = ((BasicFilter)editedFilter).Criteria;
          }
          else if (filterInfo.Filter.GetType() == typeof(CombinedFilter_AND)
         || filterInfo.Filter.GetType() == typeof(CombinedFilter_OR))
          {
            rbCombinedFilter.Checked = true;

            //show details of this filter
            foreach (FilterBriefInfoForCmb o in arrFilterInfo1OfCombinedFilter)
            {
              if (o.getFilter().Name == ((CombinedFilter)filterInfo.Filter).Filter1.Name)
                cmbFilter1OfCombinedFilter.SelectedItem = o;
            }
            foreach (FilterBriefInfoForCmb o in arrFilterInfo2OfCombinedFilter)
            {
              if (o.getFilter().Name == ((CombinedFilter)filterInfo.Filter).Filter2.Name)
                cmbFilter2OfCombinedFilter.SelectedItem = o;
            }

            if (filterInfo.Filter.GetType() == typeof(CombinedFilter_AND))
              cmbOperatorOfCombinedFilter.Text = "AND";
            else
              cmbOperatorOfCombinedFilter.Text = "OR";

          }
        }

      }

    }

    private void radioBasicFilter_CheckedChanged(object sender, EventArgs e)
    {
      grBasicFilter.Enabled = radioBasicFilter.Checked;
    }

    private void rbCombinedFilter_CheckedChanged(object sender, EventArgs e)
    {
      grCombinedFilter.Enabled = rbCombinedFilter.Checked;
    }

    private void rbNotFilter_CheckedChanged(object sender, EventArgs e)
    {
      grNotFilter.Enabled = rbNotFilter.Checked;
    }

  }
}