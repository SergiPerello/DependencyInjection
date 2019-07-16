using System;
using System.Collections.Generic;
using System.Text;

namespace Dependencias
{
    class CLI_Output : IOutput
    {
        public void Show(int number)
        {
            Console.WriteLine(number);
        }
    }
}
