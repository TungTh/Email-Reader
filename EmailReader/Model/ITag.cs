using System;
namespace EmailReader.Model
{
  public interface ITag
  {
    public void editEmailTag(IEmail email, string newValue);
    public string getEmailTag(IEmail email);
    public bool IsDefaultTag { get; }
    public string Name { get; }
    public void tagEmail(IEmail email, string value);
    public void untagEmail(IEmail email);
    public void rename(string newName);
  }
}
