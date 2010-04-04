using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EmailReader;
using EmailReader.Model;
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
    ArrayList arrTagsOfCmb = new ArrayList(); //all tags in data
    ICollection<IFilter> arrSelectedFilters = new List<IFilter>();
    IEmail selected_email;

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
          MessageBox.Show(tag.Name + " = " + tagValue);
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
      IOperator strContainOper = StringContaining.getInstance();

      IFilter basicFilter = new BasicFilter("From John", fromTag, strContainOper, "9");

      //thu apply cac filter cho email

      foreach (IEmail e in Data.getEmailCollection())
      {
        if (basicFilter.apply(e))
          MessageBox.Show("tim thay roi:" + fromTag.getEmailTag(e));
      }
    }

    void demoTaoNotFilter()
    {
      //lay tag
      IEnumerator<ITag> arrTag = Data.getTagCollection().GetEnumerator();
      arrTag.MoveNext();
      ITag fromTag = arrTag.Current;

      //tao operator
      IOperator strContainOper = StringContaining.getInstance();

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
      IOperator strContainOper = StringContaining.getInstance();

      IFilter filterForm5 = new BasicFilter("From 5", fromTag, strContainOper, "5");
      IFilter filterTo2 = new BasicFilter("To 2", toTag, strContainOper, "2");
      AbstractFilter filterFrom5AndTo2 = new CombinedFilter_AND("From 5 and to 2", filterForm5, filterTo2);

      //thu apply cac filter cho email

      foreach (IEmail e in Data.getEmailCollection())
      {
        if (filterFrom5AndTo2.apply(e))
          MessageBox.Show("tim thay roi:" + fromTag.getEmailTag(e) + toTag.getEmailTag(e));
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
      IOperator strContainOper = StringContaining.getInstance();

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

          try
          {
            eInfo.Date = Data.SentDateTag.getEmailTag(e);
          }
          catch { }

          try
          {
            eInfo.From = Data.FromTag.getEmailTag(e);
          }
          catch { }

          try
          {
            eInfo.To = Data.ToTag.getEmailTag(e);
          }
          catch { }

          try
          {
            eInfo.Subject = Data.SubjectTag.getEmailTag(e);

          }
          catch { }


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
      dtgTagOfEmail.DataSource = null;

      //get selected mail
      EmailBriefInfo email_brief_info;
      DataGridViewRow selectedRow = new DataGridViewRow();
      DataGridViewSelectedCellCollection selectedCells = dtgListEmail.SelectedCells;

      if (selectedCells.Count >= 1)
      {
        selectedRow = dtgListEmail.Rows[selectedCells[0].RowIndex];
        if (selectedRow != null && selectedRow.DataBoundItem != null)
        {
          email_brief_info = (EmailBriefInfo)selectedRow.DataBoundItem;
          IEmail email = email_brief_info.getEmail();
          this.selected_email = email; //remember selected email

          //build array of TagBriefInfo
          foreach (ITag tag in Data.getTagCollection())
          {
            if (tag.hasTag(email))
            {
              string tagValue = tag.getEmailTag(email);
              if (tagValue != "")
              {
                string tagName = tag.Name;
                arrTagInfo.Add(new TagBriefInfo(tagName, tagValue));
              }
            }
          }

          //bind to grid
          dtgTagOfEmail.DataSource = arrTagInfo;
        }
      }
    }

    private void MainScreen_Load(object sender, EventArgs e)
    {
      //new Testing.MainTest();
      showEmailList(null);
      showFilterList();
      updateCmbTags();

      controlUndoButtons();
    }

    //show all tags in the combobox
    private void updateCmbTags()
    {
      lsTags.DataSource = null;
      this.arrTagsOfCmb.Clear();
      foreach (ITag tag in Data.getTagCollection())
      {
        TagBriefInfoForCmb tag_brief_info = new TagBriefInfoForCmb(tag);
        this.arrTagsOfCmb.Add(tag_brief_info);
      }
      lsTags.DataSource = arrTagsOfCmb;
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
      Data.undo();
      controlUndoButtons();
      updateInterface();
    }

    private void btnRedo_Click(object sender, EventArgs e)
    {
      Data.redo();
      controlUndoButtons();
      updateInterface();
    }


    private void dtgListEmail_CellEnter(object sender, DataGridViewCellEventArgs e)
    {
      showTagListOfSelectedEmail();
    }

    //tag to selected email
    private void btnAddTag_Click(object sender, EventArgs e)
    {
      //if user selects existing tag
      if (lsTags.SelectedItem != null)
      {
        ITag selected_tag = ((TagBriefInfoForCmb)lsTags.SelectedItem).getTag();

        try //try add tag
        {
          selected_tag.tagEmail(selected_email, txtNewTagValue.Text);
        }
        catch //tag exist --> edit
        {
          selected_tag.editEmailTag(selected_email, txtNewTagValue.Text);
        }
      }
      else //user type new tag type, create tag and add tag to email
      {
        string new_tag_name = lsTags.Text;
        ITag new_tag = new UndoableTag(new_tag_name, false);
        Data.insertTag(new_tag);
        new_tag.tagEmail(selected_email, txtNewTagValue.Text);
      }

      showTagListOfSelectedEmail();
      updateCmbTags();
      showEmailList(arrSelectedFilters);
    }

    private void btnDeleteTagFromEmail_Click(object sender, EventArgs e)
    {
      ITag selected_tag = ((TagBriefInfoForCmb)lsTags.SelectedItem).getTag();

      try
      {
        selected_tag.untagEmail(selected_email);
      }
      catch (Exception ex)
      {
        MessageBox.Show("You want to delete tag " + selected_tag.Name + "\n" + ex.Message, "Error");
      }

      showTagListOfSelectedEmail();
      showEmailList(arrSelectedFilters);
    }

    private void btnDeleteTagType_Click(object sender, EventArgs e)
    {
      ITag selected_tag = ((TagBriefInfoForCmb)lsTags.SelectedItem).getTag();

      DialogResult dlret = MessageBox.Show("This action will delete this tag from all emails, do you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (dlret == DialogResult.Yes)
      {
        if (selected_tag.isDefaultTag == false)
        {
          Data.getTagCollection().Remove(selected_tag); //can hoi Tung lai ham cu the de xoa loai TAG

          showTagListOfSelectedEmail();
          updateCmbTags();
          showEmailList(arrSelectedFilters);
        }
        else
        {
          MessageBox.Show("You cannot delete a default tag type", "Warning!!!");
        }
      }
    }

    private void btnManageFilter_Click(object sender, EventArgs e)
    {
      FilterManager filter_manager = new FilterManager();
      filter_manager.ShowDialog();
    }

    private void updateInterface()
    {
      showTagListOfSelectedEmail();
      showFilterList();
      updateCmbTags();
      showEmailList(arrSelectedFilters);
    }

    private void controlUndoButtons()
    {
      btnUndo.Enabled = Data.ActionHandler.CanUndo;
      btnRedo.Enabled = Data.ActionHandler.CanRedo;
    }
  }
}