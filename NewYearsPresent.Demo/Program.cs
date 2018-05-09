using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewYearsPresent.Classes;
using NewYearsPresent.Enums;
using NewYearsPresent.Extension;
using NewYearsPresent.Interfaces;

namespace NewYearsPresent.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator[] creators = new Creator[2];
            creators[0] = new CandyCreator();
            creators[1] = new ChocolateCreator();

            IGift gift = new Gift();

            foreach (Creator i in creators)
            {
                if (i is CandyCreator)
                {
                    gift.Add(i.FactoryMethod("M&M", 50, 100, 125, TypeCandy.ChocolateCandy));
                    gift.Add(i.FactoryMethod("ChupaChups",25,70,70, TypeCandy.Lollipop));
                    gift.Add(i.FactoryMethod("Raffaelio",30,105,115, TypeCandy.ChocolateCandy));
                    gift.Add(i.FactoryMethod("Skittles",40,80,75,TypeCandy.Lollipop));
                }

                if (i is ChocolateCreator)
                {
                    gift.Add(i.FactoryMethod("Nestle",100,150,200,ChocolateColor.BlackChocolate));
                    gift.Add(i.FactoryMethod("Alpen Gold",120,120,150,ChocolateColor.WhiteChcolate));
                }
                
            }

            gift.Sort();
            gift.ShowItems();

            Console.WriteLine();

            foreach (var items in gift.FindCandyBySugar(30,100))
            {
                Console.WriteLine("Название: {0}, Сахар: {1}", items.name, items.sugar);  
            }

            Console.WriteLine();
            Console.WriteLine("Вес подарка: {0}", gift.GiftWeight());

            Console.ReadKey();
        }


  
    }
}
