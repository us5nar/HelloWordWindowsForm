using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MVCTest.Common;
using MVCTest.Views;

namespace MVCTest.Controllers
{
    public class IncController : IController
    {
        IView view;
        IModel model;

        // The controller which implements the IController interface ties the view and model 
        // together and attaches the view via the IModelInterface and addes the event
        // handler to the view_changed function. The view ties the controller to itself.
        public IncController(IView v, IModel m)
        {
            view = v;
            model = m;
            view.SetController(this);
            model.Attach((IModelObserver)view);
            view.Changed += new ViewHandler<IView>(this.ViewChanged);
        }

        // event which gets fired from the view when the users changes the value
        public void ViewChanged(IView v, ViewEventArgs e)
        {
            model.SetValue(e.value);
        }

        // This does the actual work of getting the model do the work
        public void IncValue()
        {
            model.IncrementValue();
        }
    }
}