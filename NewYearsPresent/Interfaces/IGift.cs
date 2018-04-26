using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewYearsPresent.Classes;

namespace NewYearsPresent.Interfaces
{
    public interface IGift
    {
        IEnumerable<Sweet> Items { get; }

        void Add(Sweet sweets);

        int GiftWeight();

        void Sort();

        IEnumerable<Sweet> FindCandyBySugar(int min, int max);
    }
}
