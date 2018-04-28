using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewYearsPresent.Enums;

namespace NewYearsPresent.Classes
{
    public class CandyCreator : Creator
    {
        public override Sweet FactoryMethod(string chocoName, int chocoWeight, int chocoSugar, int chocoCalories,
            TypeCandy type)
        {
            return new Candy(chocoName, chocoWeight, chocoSugar, chocoCalories, type);
        }

        public override Sweet FactoryMethod(string chocoName, int chocoWeight, int chocoSugar, int chocoCalories, ChocolateColor color)
        {
            throw new NotImplementedException();
        }
    }
}
