using System;
using System.Linq;

namespace ConsoleSearchValueInBoolArray {
    class Program {
        static void Main(string[] args) {
            Check();
            Console.ReadKey();
        }
        public static bool Check() {
            object[] a = { 1, 2, 3 };
            object x = 2;
            if (a.Contains(x)) { Console.WriteLine("true"); return true; }
            return false;
        }
    }
}
