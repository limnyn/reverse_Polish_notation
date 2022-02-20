using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace reverse_Polish_notation
{
    internal class Program
    {
        string OPERATORS = "+-*/()";
        int[] PERCENDENCE = { 1, 1, 2, 2, -1, -1 };
        Stack operator_stack = new Stack();

        string convert(string infix)
        {
            operator_stack = new Stack();
            


            return infix + OPERATORS;
        }
        static void Main(string[] args)
        {

        }

    }
}
