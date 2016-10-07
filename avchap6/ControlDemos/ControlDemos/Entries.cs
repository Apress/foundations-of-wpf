using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace ControlDemos
{
    public class Entries:ObservableCollection<Entry>
    {
        public Entries()
        {
            base.Add(new Entry("Bill Gates", "billg@microsoft.com"));
            base.Add(new Entry("Landon Donovan", "landycakes@hotmail.com"));
            base.Add(new Entry("Susan Ivanova", "angelofdeath@b5.com"));
        }

    }
}
