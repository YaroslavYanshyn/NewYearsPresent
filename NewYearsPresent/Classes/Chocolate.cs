using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewYearsPresent.Enums;

namespace NewYearsPresent.Classes
{
     class Chocolate : Sweet
    {
        public ChocolateColor color;

        public Chocolate(string chocoName, int chocoWeight, int chocoSugar, int chocoCalories,
            ChocolateColor chocoColor)
            : base(chocoName, chocoWeight, chocoSugar, chocoCalories)
        {
            this.color = chocoColor;
        }

        public override void TypeSweet()
        {
            Console.WriteLine(color.ToString());
        }
    }
}
