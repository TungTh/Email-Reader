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
    static ActionHandler actionHandlerOfFilterManager = new ActionHandler();

    enum EditModes { CreateNew = 1, EditOld = 2 };
    EditModes editMode;
    IFilter editedFilter; //filter is being edited

    public FilterManager()
    {
      InitializeComponent();
    }

    private void FilterManager_Load(object sender, EventArgs e)
    {
      Data.ActionHandler = actionHandlerOfFilterManager;
      showTagList();
      showOperationList();
      updateScreen();
      editMode = EditModes.CreateNew;
    }

    private void showFilterLists()
    {
      // Init data for iFilterCombobox
      iFilterBindingSource_F1.DataSource = Data.getFilterCollection();
      iFilterBindingSource_F2.DataSource = Data.getFilterCollection();
      iFilterBindingSource_NotF.DataSource = Data.getFilterCollection();
      iFilterBindingSource.DataSource = Data.getFilterCollection();

      iFilterBindingSource_F1.ResetBindings(false);
      iFilterBindingSource_F2.ResetBindings(false);
      iFilterBindingSource_NotF.ResetBindings(false);
      iFilterBindingSource.ResetBindings(false);
    }

    private void showOperationList()
    {
      iOperatorBindingSource.DataSource = Data.getOperatorCollection();
      iOperatorBindingSource.ResetBindings(false);
    }

    private void showTagList()
    {
      iTagBindingSource.DataSource = Data.getTagCollection();
      iTagBindingSource.ResetBindings(false);
    }

    private void updateScreen()
    {
      showFilterLists();
      controlUndoButtons();
    }

    private void save()
    {
      string resultMsg = "Filter haven't created";
      if (txtFilterName.Text == "")
        MessageBox.Show("You must type filter name", "Warning");
      else
      {
        if (editMode == EditModes.CreateNew) //save new filter
          resultMsg = createNewFilter(resultMsg);
        else if (editMode == EditModes.EditOld) //save edited filter 
          resultMsg = editFilter(resultMsg);
      }
      MessageBox.Show(resultMsg);
      updateScreen();
    }

    private string editFilter(string resultMsg)
    {
      if (rbNotFilter.Checked)
      {
        if (editedFilter is Filter_NOT)
          ((Filter_NOT)editedFilter).edit((IFilter)iFilterComboBox_NotF.SelectedItem);
        else
          Data.replaceFilter(editedFilter, createNotFilter());

        resultMsg = "Updated 1 NOT filter: " + editedFilter.Name;
      }
      else if (radioBasicFilter.Checked)
      {
        if (editedFilter is BasicFilter)
        {
          ITag selected_tag = (ITag)iTagComboBox.SelectedItem;
          IOperator selected_operator = (IOperator)iOperatorComboBox.SelectedItem;
          ((BasicFilter)editedFilter).edit(txtFilterName.Text, selected_tag, selected_operator, txtValue.Text);
        }
        else
          Data.replaceFilter(editedFilter, createBasicFilter());

        resultMsg = "Updated 1 Basic filter: " + editedFilter.Name;
      }
      else if (rbCombinedFilter.Checked)
      {
        Data.replaceFilter(editedFilter, createCombinedFilter());
        resultMsg = "Updated 1 Combined filter: " + editedFilter.Name;
      }
      editMode = EditModes.CreateNew;
      return resultMsg;
    }

    private string createNewFilter(string resultMsg)
    {
      if (Data.constainsFilter(txtFilterName.Text))
        resultMsg = "The filter name is already used";
      else
        if (radioBasicFilter.Checked)
        {
          Data.insertFilter(createBasicFilter());
          resultMsg = "Created 1 basic filter";
        }
        else if (rbCombinedFilter.Checked)
        {
          Data.insertFilter(createCombinedFilter());
          resultMsg = "Created 1 combined filter";
        }
        else if (rbNotFilter.Checked)
        {
          Data.insertFilter(createNotFilter());
          resultMsg = "Created 1 NOT filter";
        }
      return resultMsg;
    }

    private IFilter createCombinedFilter()
    {
      IFilter selected_filter1 = (IFilter)iFilterComboBox_F1.SelectedItem;
      IFilter selected_filter2 = (IFilter)iFilterComboBox_F2.SelectedItem;
      IFilter newFilter;

      if (cmbOperatorOfCombinedFilter.Text == "AND")
      {
        newFilter = new CombinedFilter_AND(txtFilterName.Text, selected_filter1, selected_filter2);
      }
      else
        newFilter = new CombinedFilter_OR(txtFilterName.Text, selected_filter1, selected_filter2);

      return newFilter;
    }

    private IFilter createNotFilter()
    {
      return new Filter_NOT(txtFilterName.Text, (IFilter)iFilterComboBox_NotF.SelectedItem);
    }

    private IFilter createBasicFilter()
    {
      ITag selected_tag = (ITag)iTagComboBox.SelectedItem;
      IOperator selected_operator = (IOperator)iOperatorComboBox.SelectedItem;

      //create basic filter
      IFilter filter = new BasicFilter(txtFilterName.Text, selected_tag, selected_operator, txtValue.Text);
      return filter;
    }

    private bool noFilterIsSelected()
    {
      return iFilterDataGridView.SelectedCells.Count == 0;
    }

    private IFilter getSelectedFilter()
    {
      if (noFilterIsSelected())
        return null;

      // Get the first selected cell and get its row index
      int selectedRowIndex = iFilterDataGridView.SelectedCells[0].RowIndex;
      return (IFilter)((BindingSource)iFilterDataGridView.DataSource)[selectedRowIndex];
    }

    private void controlUndoButtons()
    {
      btnUndo.Enabled = Data.ActionHandler.CanUndo;
      btnRedo.Enabled = Data.ActionHandler.CanRedo;
    }

    private void btDelete_Click(object sender, EventArgs e)
    {
      if (!noFilterIsSelected())
      {
        Data.removeFilter(getSelectedFilter());
        updateScreen();
      }
    }

    private void btSave_Click(object sender, EventArgs e)
    {
      lblStatus.Text = String.Empty;
      save();
    }

    private void btnUndo_Click(object sender, EventArgs e)
    {
      Data.ActionHandler.undo();

      updateScreen();
    }

    private void btnRedo_Click(object sender, EventArgs e)
    {
      Data.ActionHandler.redo();
      updateScreen();
    }

    private void btnEditFilter_Click(object sender, EventArgs e)
    {
      if (!noFilterIsSelected())
      {
        editMode = EditModes.EditOld;
        this.editedFilter = getSelectedFilter();
        this.txtFilterName.Text = editedFilter.Name;

        lblStatus.Text = "Editing filter \"" + editedFilter.Name + "\"";

        if (editedFilter is Filter_NOT)
        {
          //load selected NOT FILTER
          rbNotFilter.Checked = true;
          iFilterComboBox_NotF.SelectedItem = ((Filter_NOT)editedFilter).Filter;
        }
        else if (editedFilter is BasicFilter)
        {
          radioBasicFilter.Checked = true;
          iTagComboBox.SelectedItem = ((BasicFilter)editedFilter).Tag;
          iOperatorComboBox.SelectedItem = ((BasicFilter)editedFilter).Operator;
          txtValue.Text = ((BasicFilter)editedFilter).Criteria;
        }
        else if (editedFilter is CombinedFilter)
        {
          rbCombinedFilter.Checked = true;

          iFilterComboBox_F1.SelectedItem = ((CombinedFilter)editedFilter).Filter1;
          iFilterComboBox_F2.SelectedItem = ((CombinedFilter)editedFilter).Filter2;

          if (editedFilter.GetType() == typeof(CombinedFilter_AND))
            cmbOperatorOfCombinedFilter.Text = "AND";
          else
            cmbOperatorOfCombinedFilter.Text = "OR";
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

    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Dispose();
    }
  }
}