using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Basic Core Programs");
            Console.WriteLine("Enter your choice between 1 to 10: ");
            Console.WriteLine("1 For: Flip a Coin Head and Tail. ");
            Console.WriteLine("2 For: Select Value is Leap Year Or not");
            Console.WriteLine("3 For: Select Power of 2 Number");
            Console.WriteLine("4 For: Select the Harmonic Number");
            Console.WriteLine("5 For: Select Factors of number");
            int selection = Convert.ToInt32(Console.ReadLine());
            // user selection
            switch (selection)
            {
                case 1:
                    FlipCoinHeadOrTail FlipCoin = new FlipCoinHeadOrTail();
                    FlipCoin.CheckHeadTailPercentage();
                    break;
                case 2:
                    CheckLeapYearOrNot LeapYearOrNot = new CheckLeapYearOrNot();
                    LeapYearOrNot.LeapYear();
                    break;
                case 3:
                    CalculatePowerOf2 CalPower = new CalculatePowerOf2();
                    CalPower.CalcuOfPower();
                    break;
                case 4:
                    HarmonicNumber CalculateHarmonicNumber = new HarmonicNumber();
                    CalculateHarmonicNumber.CalcHarmonicSeries();
                    break;
                case 5:
                    PrimeFactorization PrimeFactor = new PrimeFactorization();
                    PrimeFactor.CalcSFactorialSeries();
                    break;
                default:
                    Console.WriteLine("Invalid Selection Select Between 1.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
