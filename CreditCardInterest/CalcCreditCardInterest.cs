using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreditCardInterest
{
    public class CreditCardInterest
    {
         public static double CalcInterest(string CardType, double Amount)
        {
            double Rate = 0;
            switch (CardType)
            {
                case "Visa": Rate = 0.1;
                    break;
                case "MC": Rate = 0.05;
                    break;
                case "Discover": Rate = 0.01;
                    break;
                   
            }
            return Amount * Rate;
        }

       
    }
}
