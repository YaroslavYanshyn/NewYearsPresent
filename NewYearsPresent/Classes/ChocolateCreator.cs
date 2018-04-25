using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewYearsPresent.Enums;

namespace NewYearsPresent.Classes
{
    public class ChocolateCreator : Creator
    {
        public override Sweet FactoryMethod(string chocoName, int chocoWeight, int chocoSugar, int chocoCalories,
            ChocolateColor chocolateColor)
        {
            return  new Chocolate(chocoName, chocoWeight, chocoSugar, chocoCalories, chocolateColor);
        }

        public override Sweet FactoryMethod(string chocoName, int chocoWeight, int chocoSugar, int chocoCalories,TypeCandy type)
        {
            throw  new NotImplementedException();
        }
    }
}
