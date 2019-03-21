using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MVCTest.Common;

namespace MVCTest
{
    
    // The Model interface where we can Attach the function to be notified when value
    // is changed. An actual data manipulation function IncrementValue which increments the value
    // A SetValue function which sets the value when users changes the textbox
    public interface IModel
    {
        void Attach(IModelObserver imo);
        void IncrementValue();
        void SetValue(int v);
    }

}
