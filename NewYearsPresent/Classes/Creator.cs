using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewYearsPresent.Enums;

namespace NewYearsPresent.Classes
{
    public abstract class Creator
    {
        public abstract Sweet FactoryMethod(string candyName, int candyWeight, int candySugar, int candyCalories, TypeCandy type);

        public abstract Sweet FactoryMethod(string candyName, int candyWeight, int candySugar, int candyCalories, ChocolateColor color);
    }
}
