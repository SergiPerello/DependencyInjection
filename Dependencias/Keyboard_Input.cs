using System;
using System.Collections.Generic;
using System.Text;

namespace Dependencias
{
    class Keyboard_Input : IInput
    {
        public int RequestNumber()
        {
            int number = int.Parse(Console.ReadLine());
            return number;
        }
    }
}
