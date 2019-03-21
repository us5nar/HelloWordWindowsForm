using MVCTest.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCTest
{
        // Currently, the interface only contains the method to set the controller to which
        // it is tied. The rest of the view related code is implemented in the form.
        public interface IView
        {
            event ViewHandler<IView> Changed;
            void SetController(IController cont);
        }
}
