using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> user = new List<int>() { 1,2,3,4};
            user.Add(1);
            foreach (var item in user)
            {
                Console.WriteLine(item);
            }
           
            Console.ReadKey();

            
        }
    }
}
