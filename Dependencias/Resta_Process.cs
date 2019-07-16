using System;
using System.Collections.Generic;
using System.Text;

namespace Dependencias
{
    class Resta_Process : IProcess
    {
        public int Operation(int number1)
        {
            return number1 - number1;
        }
    }
}
