using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Program
{
    class FlipCoinHeadOrTail
    {
        public int FlipHeads = 0;
        public int FlipHails = 0;


        public void CheckHeadTailPercentage()
        {
            Console.WriteLine("Enter How many times you want to Flip a Coin : ");
            int FlipNumber = Convert.ToInt32(Console.ReadLine());

            for (int coinFlip = 0; coinFlip <= FlipNumber; coinFlip++)
            {
                Random random = new Random();
                double CheckFlipCoin = random.NextDouble();
                if (CheckFlipCoin < 0.5)
                {
                    Console.WriteLine("Result: Is Head");
                    FlipHeads++;
                }
                else
                {
                    Console.WriteLine("Result: Is Tail");
                    FlipHails++;
                }
            }
            double CheckPercentageTails = (FlipHeads * 100) / FlipNumber;
            double CheckPercentageHeads = (FlipHails * 100) / FlipNumber;
            Console.WriteLine("percentage of heads and tails is : " + CheckPercentageTails + " " + CheckPercentageHeads);
            Console.ReadKey();
        }
        
    }
}