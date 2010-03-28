using System;
using System.Collections.Generic;
using System.Text;
using EmailReader.Model;
using EmailReader.Model.Operator;
namespace EmailReader.Testing
{
  public class MainTest
  {

    public MainTest()
    {
      testDeleteTag();
    }

    void testDeleteTag()
    {
      ITag tag = new Tag("Flag", false);

      IFilter filterRed = new BasicFilter("Red Flag", tag, StringContaining.getInstance(), "red");
      IFilter filterYellow = new BasicFilter("Yellow Flag", tag, StringContaining.getInstance(), "yellow");
      IFilter filterRedOrYello = new CombinedFilter_OR("Red or Yellow", filterRed, filterYellow);

      Data.insertTag(tag);
      Data.insertFilter(filterRed);
      Data.insertFilter(filterYellow);
      Data.insertFilter(filterRedOrYello);

      int i = 0;
      foreach (IEmail email in Data.getEmailCollection())
      {
        string value = i % 2 == 0 ? "yellow" : "red";
        tag.tagEmail(email, value);
        i++;
        if (i == 10) break;
      }

      System.Windows.Forms.MessageBox.Show(Data.getFilterCollection().Count.ToString());
      Data.removeTag(tag);
      System.Windows.Forms.MessageBox.Show(Data.getFilterCollection().Count.ToString());
    }

    void printEmail(ITag tag, IEmail email)
    {
      System.Windows.Forms.MessageBox.Show(tag.getEmailTag(email));
    }
  }
}
