using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsDelegate
{
    internal class DelegateClass
    {
        private DelegateClass() { }

        private readonly static DelegateClass _instance = new DelegateClass();
        public static DelegateClass Instance 
        { 
          get 
          { 
                return _instance; 
          } 
        }

        public delegate int T2Numbers_delegate(int num1, int num2);

        public int Addition(int num1, int num2)
        {
            return (num1 + num2);
        }

        public int Subtraction(int num1, int num2)
        {
            return (num1 - num2);
        }

        public int Mult(int num1, int num2)
        {
            return (num1 * num2);
        }

        public int Division(int num1, int num2)
        {
            return (num1 / num2);
        }

        public int Calc(int a, int b, T2Numbers_delegate func)
        {
            return func(a, b) + 10;
        }
    }
}
