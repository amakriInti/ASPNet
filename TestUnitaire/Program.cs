using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUnitaire
{
    // TDD : Test Driven Dev
    class Program
    {
        static void Main(string[] args)
        {
            var cal = new Calculatrice { Op1 = 7, Op2 = 8 };
            int res = 0;
            var b = cal.Div(out res);

            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
    public class Calculatrice
    {
        public int Op1;
        public int Op2;
        public int Add() { return Op1 + Op2; }
        public bool Div(out int res)
        {
            res = 0;
            try
            {
                res = Op1 / Op2;
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
