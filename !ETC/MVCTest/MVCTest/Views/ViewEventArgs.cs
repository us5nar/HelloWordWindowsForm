using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCTest.Views
{
    public delegate void ViewHandler<IView>(IView sender, ViewEventArgs e);

    // The event arguments class that will be used while firing the events
    // for this program, we have only one value which the user changed.
    public class ViewEventArgs : EventArgs
    {
        public int value;
        public ViewEventArgs(int v) { value = v; }
    }

}
