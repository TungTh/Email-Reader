using System;
namespace EmailReader.Model
{
  public interface ITag
  {
    void editEmailTag(IEmail email, string newValue);
    string getEmailTag(IEmail email);
    bool isDefaultTag { get; }
    string Name { get; }
    void tagEmail(IEmail email, string value);
    void untagEmail(IEmail email);
    void rename(string newName);

  }
}
