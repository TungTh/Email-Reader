using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EmailReader;
using EmailReader.Model;
using EmailReader.Model.Command;
using EmailReader.Model.Operator;
using EmailReader.View;
using System.Collections;

namespace EmailReader
{
  public partial class MainScreen : Form
  {
    //for displaying List of Tags and List of Emails
    ArrayList arrEmailInfo = new ArrayList();
    ArrayList arrFilterInfo = new ArrayList();
    ArrayList arrTagInfo = new ArrayList();
    ICollection<IFilter> arrSelectedFilters = new List<IFilter>();
    IEmail selected_email = null;
    IActionHandler actionHandleOfMainScreen = null;

    public MainScreen()
    {
      InitializeComponent();
    }

    private bool testEmailWithFilters(IEmail e, ICollection<IFilter> selectedFilters)
    {
      bool ret = true;

      if (selectedFilters != null)
      {
        foreach (IFilter f in selectedFilters)
        {
          if (f.apply(e) == false)
          {
            ret = false;
            break;
          }
        }
      }

      return ret;
    }

    private void showEmailList(ICollection<IFilter> selectedFilters)
    {
      dtgListEmail.DataSource = null;
      arrEmailInfo.Clear();

      //build arr 
      foreach (IEmail e in Data.getEmailCollection())
      {
        if (testEmailWithFilters(e, selectedFilters))
        {
          EmailBriefInfo eInfo = new EmailBriefInfo(e);

          eInfo.Date = Data.SentDateTag.getEmailTag(e);
          eInfo.From = Data.FromTag.getEmailTag(e);
          eInfo.To = Data.ToTag.getEmailTag(e);
          eInfo.Subject = Data.SubjectTag.getEmailTag(e);

          eInfo.setEmail(e);
          arrEmailInfo.Add(eInfo);
        }
      }

      //data binding
      dtgListEmail.DataSource = arrEmailInfo;
      showTagListOfSelectedEmail();
    }

    private void showFilterList()
    {
      arrFilterInfo.Clear();
      foreach (IFilter filter in Data.getFilterCollection())
      {
        FilterBriefInfo fInfo = new FilterBriefInfo(filter);
        arrFilterInfo.Add(fInfo);
      }
      filterBriefInfoBindingSource.ResetBindings(false);
      filterBriefInfoBindingSource.DataSource = arrFilterInfo;
    }

    private void showTagListOfSelectedEmail()
    {
      arrTagInfo.Clear();

      //get selected mail
      EmailBriefInfo email_brief_info;
      DataGridViewRow selectedRow = new DataGridViewRow();
      DataGridViewSelectedCellCollection selectedCells = dtgListEmail.SelectedCells;

      if (selectedCells.Count >= 1)
      {
        // Get the first selected cell and get its row index
        selectedRow = dtgListEmail.Rows[selectedCells[0].RowIndex];
        if (selectedRow != null && selectedRow.DataBoundItem != null)
        {
          email_brief_info = (EmailBriefInfo)selectedRow.DataBoundItem;
          IEmail email = email_brief_info.getEmail();
          this.selected_email = email; //store selected email

          //build list of TagBriefInfo
          foreach (ITag tag in Data.getTagCollection())
          {
            if (tag.hasTag(email))
            {
              string tagValue = tag.getEmailTag(email);
              if (tagValue != "")
              {
                string tagName = tag.Name;
                arrTagInfo.Add(new TagBriefInfo(tag, tagName, tagValue));
              }
            }
          }
          //bind to grid
          tagBriefInfoBindingSource.DataSource = arrTagInfo;
          tagBriefInfoBindingSource.ResetBindings(false);
        }
      }
    }

    private void MainScreen_Load(object sender, EventArgs e)
    {
      new Testing.MainTest();

      //set action Handle of the MainScreen
      actionHandleOfMainScreen = Data.ActionHandler;
      updateMainScreen();
    }

    //show all tags in the combobox
    private void updateCmbTags()
    {
      iTagBindingSource.DataSource = Data.getTagCollection();
      iTagBindingSource.ResetBindings(false);
    }

    private void controlUndoButtons()
    {
      btnUndo.Enabled = Data.ActionHandler.CanUndo;
      btnRedo.Enabled = Data.ActionHandler.CanRedo;
    }

    private void updateMainScreen()
    {
      showFilterList();
      showEmailList(arrSelectedFilters);
      showTagListOfSelectedEmail();
      updateCmbTags();
      controlUndoButtons();
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btnApplyFilter_Click(object sender, EventArgs e)
    {
      //get selected filters
      arrSelectedFilters.Clear();

      foreach (FilterBriefInfo filterInfo in arrFilterInfo)
      {
        if (filterInfo.IsSelected)
          arrSelectedFilters.Add(filterInfo.Filter);
      }
      showEmailList(arrSelectedFilters);
    }

    private void btnUndo_Click(object sender, EventArgs e)
    {
      Data.ActionHandler.undo();
      updateMainScreen();
    }

    private void btnRedo_Click(object sender, EventArgs e)
    {
      Data.ActionHandler.redo();
      updateMainScreen();
    }

    private void dtgListEmail_CellEnter(object sender, DataGridViewCellEventArgs e)
    {
      showTagListOfSelectedEmail();
    }

    //tag the selected email
    private void btnAddTag_Click(object sender, EventArgs e)
    {
      //if user selects existing tag
      if (iTagComboBox.SelectedItem != null)
      {
        ITag selected_tag = (ITag)iTagComboBox.SelectedItem;
        if (selected_tag.hasTag(selected_email))
          selected_tag.editEmailTag(selected_email, txtNewTagValue.Text);
        else
          selected_tag.tagEmail(selected_email, txtNewTagValue.Text);
      }
      else //user type new tag type, create tag and add tag to email
      {
        string new_tag_name = iTagComboBox.Text;
        ITag new_tag = new UndoableTag(new_tag_name, false);
        Data.insertTag(new_tag);
        new_tag.tagEmail(selected_email, txtNewTagValue.Text);
      }

      updateMainScreen();
    }

    private void btnDeleteTagFromEmail_Click(object sender, EventArgs e)
    {
      ITag selected_tag = (ITag)iTagComboBox.SelectedItem;
      if (selected_tag.isDefaultTag)
        MessageBox.Show("You can not untag default tag", "Warning");
      else
      {
        if (selected_tag.hasTag(selected_email))
        {
          selected_tag.untagEmail(selected_email);
          updateMainScreen();
        }
      }
    }

    private void btnDeleteTagType_Click(object sender, EventArgs e)
    {
      ITag selected_tag = (ITag)iTagComboBox.SelectedItem;

      DialogResult dlret = MessageBox.Show("This action will delete this tag from all emails, do you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (dlret == DialogResult.Yes)
      {
        if (!selected_tag.isDefaultTag)
        {
          Data.removeTag(selected_tag);
          updateMainScreen();
        }
        else
          MessageBox.Show("You cannot delete a default tag type", "Warning!!!");
      }
    }

    private void btnManageFilter_Click(object sender, EventArgs e)
    {
      FilterManager filter_manager = new FilterManager();
      filter_manager.ShowDialog();
      Data.ActionHandler = actionHandleOfMainScreen; //restore action handle for mainscreen
      updateMainScreen();
    }

    private void tagBriefInfoDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
    {
      if (tagBriefInfoDataGridView.SelectedCells.Count > 0)
      {
        // Get the first selected cell and get its row index
        int selectedRowIndex = tagBriefInfoDataGridView.SelectedCells[0].RowIndex;
        TagBriefInfo tag = (TagBriefInfo)((BindingSource)tagBriefInfoDataGridView.DataSource)[selectedRowIndex];
        iTagComboBox.SelectedItem = tag.getTag();

        txtNewTagValue.Text = tagBriefInfoDataGridView.Rows[selectedRowIndex].Cells[tagValueColumn.Index].Value.ToString();
      }
    }

    private void iTagComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      txtNewTagValue.Text = string.Empty;
    }
  }
}