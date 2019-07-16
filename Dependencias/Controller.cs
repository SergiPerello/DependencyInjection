using System;
using System.Collections.Generic;
using System.Text;

namespace Dependencias
{
    class Controller
    {
        IInput input;
        IProcess process;
        IOutput output;
        public Controller(IInput a, IProcess b, IOutput c)
        {
            input = a;
            process = b;
            output = c;
        }
        public void Execute()
        {
            int number = input.RequestNumber();
            int result = process.Operation(number);
            output.Show(result);
        }
    }
}
