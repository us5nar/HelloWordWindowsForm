using System;

namespace HelloWordWindowsForms.Models
{
    class NumbersGenerator
    {
        public int Generate(int range)
        {
            Random chaosRnd = new Random();
            int randomInt = chaosRnd.Next(range);
            return randomInt;
        }

    }
}
