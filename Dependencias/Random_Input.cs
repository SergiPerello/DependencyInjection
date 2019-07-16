using System;
using System.Collections.Generic;
using System.Text;

namespace Dependencias
{
    class Random_Input : IInput
    {
        public int RequestNumber()
        {
            Random random = new Random();
            return random.Next(9);
        }
    }
}
