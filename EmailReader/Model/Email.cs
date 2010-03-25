using System;
using System.Collections.Generic;
using System.Text;

namespace EmailReader.Model
{
  public class Email : EmailReader.Model.IEmail
  {
    private int _ID;

    public int ID
    {
      get { return _ID; }
    }

    public Email(int ID)
    {
      _ID = ID;
    }
  }
}
