using System;

namespace Dependencias
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller a = new Controller(new Random_Input(), new Suma_Process(), new CLI_Output());
            a.Execute();
        }
    }
}
