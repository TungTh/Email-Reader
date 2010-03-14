using System;
using System.Collections.Generic;
using System.Text;
using EmailReader.Model.Observer;
namespace EmailReader.Model
{
    public class Tag : EmailReader.Model.ITag, ISubject
    {
        private Subject subject;
        string _Name;
        public string Name
        {
            get { return _Name; }
        }
        bool _IsDefaultTag;
        public bool IsDefaultTag
        {
            get { return _IsDefaultTag; }
        }

        Dictionary<IEmail, string> _TaggedEmails = new Dictionary<IEmail, string>();

        #region Constructor
        protected Tag(string name, bool isDefault)
        {
            _Name = name;
            _IsDefaultTag = isDefault;
            subject = new Subject();
        }
        #endregion

        #region Methods
        public void tagEmail(IEmail email, string value)
        {
            if (!_TaggedEmails.ContainsKey(email))
                _TaggedEmails.Add(email, value);
            else throw new Exception("This email was already existed");
        }

        public void untagEmail(IEmail email)
        {
            if (_TaggedEmails.ContainsKey(email))
                _TaggedEmails.Remove(email);
            else throw new Exception("This email can not untag because it was not existed");
        }

        public void editEmailTag(IEmail email, string newValue)
        {
            untagEmail(email);
            tagEmail(email, newValue);
        }

        public string getEmailTag(IEmail email)
        {
            if (!_TaggedEmails.ContainsKey(email))
                throw new Exception("This email was not existed");
            return _TaggedEmails[email];

        }
        public void rename(string newName)
        {
            this.Name = newName;
        }
        #endregion

        #region Observable

       public  void AttachObserver(IObserver o)
        {
            subject.AttachObserver(o);
        }
        public void notifyObserver()
        {
            subject.notifyObserver();
        }
        public void DetachObserver(IObserver o)
        {
            subject.DetachObserver(o);
        }
        #endregion
    }
}

