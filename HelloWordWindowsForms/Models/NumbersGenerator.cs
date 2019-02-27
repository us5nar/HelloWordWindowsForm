using System;

namespace HelloWordWindowsForms.Models
{
    class NumbersGenerator
    {
        public int Generate(int range)
        {
            Random newRandomNmber = new Random();
            int number = newRandomNmber.Next(range);
            return number;
        }

    }
}
