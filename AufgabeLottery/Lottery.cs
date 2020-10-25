using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace AufgabeLottery
{
    class Lottery
    {
        public int[] ticketNumbers = new int[6];
        public Lottery()
        {
        }
        public List<int> returnLottoNumbers()
        {
            List<int> lottoNumbers = new List<int>();
            var rand = new Random();
            for (int i = 0; i < 6; i++)
            {
                int randomNummer = rand.Next(1,46);
                if (lottoNumbers.Contains(randomNummer) == false)
                {
                    lottoNumbers.Add(randomNummer);
                } else { i--; }
            }
            return lottoNumbers;
        }

    }
}
