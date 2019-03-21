using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCTest
{
    // The Icontroller supports only one functionality that is to IncrementValue the value
    public interface IController
    {
        void IncValue();
    }

}
