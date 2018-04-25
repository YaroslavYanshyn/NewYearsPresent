using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewYearsPresent.Enums;

namespace NewYearsPresent.Classes
{
    class Candy : Sweet
    {
        public TypeCandy type;

        public Candy(string candyName, int candyWeight, int candySugar, int candyCalories, TypeCandy type)
            : base(candyName, candyWeight, candySugar, candyCalories)
        {
            this.type = type;
        }

        public override void TypeSweet()
        {
            Console.WriteLine(type.ToString());
        }
    }
}
