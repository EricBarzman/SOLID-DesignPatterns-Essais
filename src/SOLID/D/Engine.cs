using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.SOLID.D
{
    public class Engine : IEngine
    {
        public void Start()
        {
            System.Console.WriteLine("Engine started");
        }
    }
}