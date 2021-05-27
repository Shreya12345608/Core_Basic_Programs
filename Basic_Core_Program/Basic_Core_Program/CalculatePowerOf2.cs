using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Program
{

    class CalculatePowerOf2
    {
        public int num = 0;
        public void CalcuOfPower()
        {
            
            Console.Write("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int result = num * 2;
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
