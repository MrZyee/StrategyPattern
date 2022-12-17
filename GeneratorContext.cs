using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class GeneratorContext
    {
        private IGenerator _generator;
        public GeneratorContext(IGenerator generator)
        {
            _generator = generator;
        }

        public void SetGenerator(IGenerator generator)
        {
            _generator = generator;
        }

        public void GenerateFile()
        {
            _generator.Generate();
        }
    }
}
