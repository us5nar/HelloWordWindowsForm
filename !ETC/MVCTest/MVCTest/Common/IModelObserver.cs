using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MVCTest.Models;

namespace MVCTest.Common
{
    // The interface which the form/view must implement so that, the event will be
    // fired when a value is changed in the model.
    public interface IModelObserver
    {
        void ValueIncremented(IModel model, ModelEventArgs e);
    }
}
