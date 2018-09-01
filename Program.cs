using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rant;

namespace AlinhamentoZuado
{
    class Program
    {
        static void Main(string[] args)
        {
            int repetition = 10;
            string text;

            var rant = new RantEngine();
            rant.LoadPackage("build/AlinhamentoZuado-0.0.1.rantpkg");

            var program = RantProgram.CompileFile("alinhamentoZuado.rant");

            for (int i = 0; i < repetition; i++)
            {
                text = rant.Do(program);
                Console.WriteLine(text);
            }

        }
    }
}
