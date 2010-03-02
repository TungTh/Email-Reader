using System;
using System.Collections.Generic;
using System.Text;

namespace EmailReader.Model
{
  public class Parent
  {
    public Parent()
    {
    }

    public void Hello()
    {
      System.Diagnostics.Debug.Assert(false, this.ToString());
    }
  }
}
