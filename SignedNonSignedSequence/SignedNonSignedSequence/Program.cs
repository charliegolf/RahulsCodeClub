using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignedNonSignedSequence
{
    class Program
    {
        static void Main(string[] args)
        {

            int pos = 2;
            int neg = -3;
            int[] posNo = new int[99];
            int[] negNo = new int[99];

            for (int i = 0; i < posNo.Length; i++)
            {
                posNo[i] = pos;
                pos++;
            }

            for (int i = 0; i < negNo.Length; i++)
            {
                negNo[i] = neg;
                neg--;
            }

           int posPosition = 0;
           int negPosition = 0;

           for(int i=0; i<=49; i++)
            {
                Console.Write(posNo[posPosition]+" ");
                posPosition++;
                posPosition++;
                Console.Write(negNo[negPosition] + " ");
                negPosition++;
                negPosition++;
            }
            Console.ReadKey();
        }

    }
}
