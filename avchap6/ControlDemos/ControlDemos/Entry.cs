using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace ControlDemos
{
    public class Entry
    {
      public Entry (string Inname, string InemailAddress)
      {
       this.Name = Inname;
       this.EmailAddress = InemailAddress;
      }

      private string mEmailAddress;
      public string EmailAddress
      {
       get { return mEmailAddress; }
       set { mEmailAddress = value; }
      }

      private string mName;
      public string Name
      {
       get { return mName; }
       set { mName = value; }
      }

      public override string ToString ()
      {
       return this.Name + " : " + this.EmailAddress;
      }
    }
}
