using ClothingBusiness.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayOutput _output = new DisplayOutput();
            _output.RunProgram();
            _output.DisplayRecipt();
            Console.ReadLine();
        }
    }
}
