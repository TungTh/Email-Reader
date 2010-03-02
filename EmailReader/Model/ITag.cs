using System;
namespace EmailReader.Model
{
  public interface ITag
  {
    void editEmailTag(int emailID, string newValue);
    string getEmailTag(int emailID);
    bool IsDefaultTag { get; }
    string Name { get; }
    void tagEmail(int emailID, string value);
    void untagEmail(int emailID);
  }
}
