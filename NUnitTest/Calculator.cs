﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumCsharp.NUnitTest
{
    internal class Calculator
    { //Addition
        public int Add(int a, int b)
        {
            int c = a + b;
            return c;
        }
        //Subtraction
        public int Sub(int a, int b)
        {
            int c = a - b;
            return c;
        }

        //Division
        public int Div(int a, int b)
        {
            int c = a / b;
            return c;
        }

        //Multiplication
        public int Mul(int a, int b)
        {
            int c = a * b;
            return c;
        }
    }
}
