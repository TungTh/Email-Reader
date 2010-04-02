using System;
using System.Collections.Generic;
using System.Text;
using EmailReader.Model;

namespace EmailReader.View
{
    class EmailBriefInfo
    {
        string date, from, to, subject;
        IEmail e;

        public string Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public string From
        {
            get
            {
                return from;
            }

            set
            {
                from = value;
            }
        }

        public string To
        {
            get
            {
                return to;
            }

            set
            {
                to = value;
            }
        }

        public string Subject
        {
            get
            {
                return subject;
            }

            set
            {
                subject = value;
            }
        }

        public IEmail getEmail()
        {
           return e;
        }

        public void setEmail(IEmail e)
        {
            this.e = e;
        }

        public EmailBriefInfo(IEmail e)
        {
            this.e = e;
        }
    }
}
