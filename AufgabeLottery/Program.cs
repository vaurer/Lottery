using System;
using System.Collections.Generic;
using System.Linq;

namespace AufgabeLottery
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 1; i++)
            {
                var numbers = new List<int>();
                for (int j = 1; j < 7; j++)
                {
                    Console.WriteLine("enter the number " + j + " which must be between 1 and 45");
                    int intTemp = Convert.ToInt32(Console.ReadLine());
                    if (intTemp>0 && intTemp<46 && numbers.Contains(intTemp)==false)
                    {
                        numbers.Add(intTemp);
                    } else { j--; }
                }

                LotteryTicket lotteryTicket = new LotteryTicket();
                var x = 0;
                foreach (var item in numbers)
                {
                    lotteryTicket.ticketNumbers[x++] = item;
                }

                var counter = 0;
                Console.WriteLine();
                Console.Write("YOUR numbers: ");
                for (int k = 0; k < lotteryTicket.ticketNumbers.Length; k++)
                {
                    Console.Write(lotteryTicket.ticketNumbers[k] + " | " );
                }
                Console.WriteLine();

                Lottery lotto = new Lottery();
                var lottoNumbers = lotto.returnLottoNumbers();
                Console.Write("LOTTO numbers: ");
                for (int m = 0; m < lotto.returnLottoNumbers().Count; m++)
                {
                    Console.Write(lottoNumbers[m]+ " | ");
                    if (lotteryTicket.ticketNumbers.Contains(lottoNumbers[m]))
                    {
                        counter++;
                    }
                }
                Console.WriteLine();
                Console.WriteLine("YOU have "+counter+" hits!");
            }
        }
    }
}
