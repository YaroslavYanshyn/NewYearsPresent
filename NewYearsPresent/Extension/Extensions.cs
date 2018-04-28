using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewYearsPresent.Interfaces;

namespace NewYearsPresent.Extension
{
    public static class Extensions
    {
        public static void ShowItems(this IGift gift)
        {
            Console.WriteLine("Набор конфет: ");
            foreach (var i in gift.Items)
            {
                Console.WriteLine("Название конфеты: {0}, Вес конфеты: {1}, Caxap: {2}, Колории: {3}",i.name, i.weight, i.sugar, i.calories);
                
            }
        }
    }
}
