using System;
using EmailReader.Model.Observer;
namespace EmailReader.Model
{
  public interface ITag : ISubject
  {
    void editEmailTag(IEmail email, string newValue);
    string getEmailTag(IEmail email);
    bool isDefaultTag { get; }
    string Name { get; }
    void tagEmail(IEmail email, string value);
    void untagEmail(IEmail email);
    void rename(string newName);
    bool hasTag(IEmail email);
  }
}
