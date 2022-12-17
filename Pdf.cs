using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class Pdf : IGenerator
    {
        public void Generate()
        {
            Console.WriteLine("Print PDF....");
        }
    }
}
