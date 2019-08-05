using System;
using System.Text;
using System.Linq;

namespace Build_Tower
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = TowerBuilder(10);
            foreach(string o in s)
            {
                Console.WriteLine(o);
            }
        }

        public static string[] TowerBuilder(int nFloors)
        {
            return Enumerable.Range(1, nFloors).Select(i => new string(' ', nFloors - i) + new string('*', 2 * i - 1) + new string(' ', nFloors - i)).ToArray();
        }
    }
}
