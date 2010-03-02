using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace EmailReader.Model
{
  public partial class Test : Form
  {
    ActionHandler actionHandle = new ActionHandler();
    int _currentActionNumber = 0;
    public Test()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      SelfDeteleTag("Tag1");
    }

    private void SelfDeteleTag(string tag)
    {
      actionHandle.BeginMacro();
      SelfDeleteBasicFilter("BasicF1");
      SelfDeleteBasicFilter("BasicF2");
      DeleteTag(tag);
      actionHandle.EndMacro();
    }

    private void SelfDeleteBasicFilter(string filter)
    {
      actionHandle.BeginMacro();
      SelfDeleteComboFilter(filter + "_ComboF1");
      SelfDeleteComboFilter(filter + "_ComboF2");
      DeleteBasicFilter(filter);
      actionHandle.EndMacro();
    }

    private void SelfDeleteComboFilter(string filter)
    {
      actionHandle.BeginMacro();
      DeleteComboFilter(filter);
      actionHandle.EndMacro();
    }

    public void Unregister(string Observer)
    {
      Debug.WriteLine(Observer + "Unregister");
    }

    public void Register(string Observer)
    {
      Debug.WriteLine(Observer + " Register");
    }

    public void DeleteComboFilter(string ComboFilter)
    {
      actionHandle.StoreAction(new InsertComboFilter(this, ComboFilter));
      Debug.WriteLine(ComboFilter + " Delete");
    }

    public void InsertComboFilter(string ComboFilter)
    {
      actionHandle.StoreAction(new DeleteComboFilter(this, ComboFilter));
      Debug.WriteLine(ComboFilter + " Insert");
    }

    public void DeleteTag(string Tag)
    {
      actionHandle.StoreAction(new InsertTag(this, Tag));
      Debug.WriteLine(Tag + " Delete");
    }

    public void InsertTag(string Tag)
    {
      actionHandle.StoreAction(new DeleteTag(this, Tag));
      Debug.WriteLine(Tag + " Insert");
    }

    public void DeleteBasicFilter(string BasicFilter)
    {
      actionHandle.StoreAction(new InsertBasicFilter(this, BasicFilter));
      Debug.WriteLine(BasicFilter + " Delete");
    }

    public void InsertBasicFilter(string BasicFilter)
    {
      actionHandle.StoreAction(new DeleteBasicFilter(this, BasicFilter));
      Debug.WriteLine(BasicFilter + " Insert");
    }

    private void button2_Click(object sender, EventArgs e)
    {
      actionHandle.Undo();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      actionHandle.Redo();
    }
  }
}