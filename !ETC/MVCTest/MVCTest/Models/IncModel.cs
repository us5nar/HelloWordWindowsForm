using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MVCTest.Common;

namespace MVCTest.Models
{
    public class IncModel : IModel
    {
        public event ModelHandler<IncModel> Changed;

        int value;

        // implementation of IModel interface
        // Constrctor - set the initial value to 0
        public IncModel()
        {
            value = 0;
        }

        // SetValue - function to set the value in case when user changes the value in the textbox
        // and the view change event fires in the controller
        public void SetValue(int v)
        {
            value = v;
        }

        // Change the value and fire the event with the new value inside ModelEventArgs
        // This will invoke the function valueIncremented in the model
        // and will be displayed in the textbox subsequently
        public void IncrementValue()
        {
            value++;
            Changed.Invoke(this, new ModelEventArgs(value));
        }

        // Attach the function which is implementing the IModelObserver so that it can be
        // notified when a value is changed
        public void Attach(IModelObserver incModelObserver)
        {
            Changed += new ModelHandler<IncModel>(incModelObserver.ValueIncremented);
        }
    }
}