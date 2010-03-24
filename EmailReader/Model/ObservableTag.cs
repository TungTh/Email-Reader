using System;
using System.Collections.Generic;
using System.Text;
using EmailReader.Model.Observer;
namespace EmailReader.Model
{
  public abstract class ObservableTag : ITag
  {
    Subject _subject = new Subject();
    protected string _name = null;
    protected bool _isDefault = false;

    #region ISubject Members

    public void attachObserver(IObserver o)
    {
      _subject.attachObserver(o);
    }

    public void notifyObserver()
    {
      _subject.notifyObserver();
    }

    public void detachObserver(IObserver o)
    {
      _subject.detachObserver(o);
    }

    #endregion

    #region ITag Members
    public string Name { get { return _name; } }
    public bool isDefaultTag { get { return _isDefault; } }
    public ObservableTag(string name, bool isDefault)
    {
      _name = name;
      _isDefault = isDefault;
    }
    public virtual void rename(string newName)
    {
      _name = newName;
    }
    public abstract void editEmailTag(IEmail email, string newValue);
    public abstract string getEmailTag(IEmail email);
    public abstract void tagEmail(IEmail email, string value);
    public abstract void untagEmail(IEmail email);
    #endregion

  }
}
