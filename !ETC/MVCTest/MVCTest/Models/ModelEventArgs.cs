using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCTest.Models
{
    public delegate void ModelHandler<IModel>(IModel sender, ModelEventArgs e);

    // The ModelEventArgs class which is derived from th EventArgs class to 
    // be passed on to the controller when the value is changed
    public class ModelEventArgs : EventArgs
    {
        public int newval;
        public ModelEventArgs(int v)
        {
            newval = v;
        }
    }
}
