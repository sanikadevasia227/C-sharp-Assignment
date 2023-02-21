using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_3
{
    class Assignment1storage
    {
        public static void Main()
        {
            var res = Client.Add(10, 15, 20);
            Client.Storage(res);
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
    public static class Client
    {
        private static int _resStore = 0;
        public static int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
        public static void Storage(int result)
        {
            _resStore = result;
        }
    }
}
