using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprendizagem.ExerciciosLogica
{
    public class SubscriptionRenewalNotice
    {
        public string SubscriptionExpirationMessage(int daysUntilExpiration)
        {
            if (daysUntilExpiration == 0)
            {
                return "Your subscription has expired.";
            }
            else if (daysUntilExpiration <= 1)
            {
                return @"Your subscription expires within a day! Renew now and save 20%!";
            }
            else if (daysUntilExpiration <= 5)
            {
                return $@"Your subscription expires in {daysUntilExpiration} days. Renew now and save {SubscriptionExpirationDiscount(daysUntilExpiration)}%!";
            }
            else if (daysUntilExpiration <= 10)
            {
                return "Your subscription will expire soon. Renew now!";
            }
            else
            {
                return "Your subscription up to date!";
            }
        }

        public int SubscriptionExpirationDiscount (int daysUntilExpiration)
        {
            if (daysUntilExpiration <= 1 && daysUntilExpiration > 0)
            {
                    return 20;
            }
            else if(daysUntilExpiration <= 5 && daysUntilExpiration > 1)
            {
                    return 10;
            }
            else { return 0; }
        }
    }
  




       
       /* 
        Random value = new Random();
        int saleAmount = value.Next(950,1050);

        int discount = saleAmount > 1000 ? 100 : 50;

        Console.WriteLine($"Valor venda: {saleAmount}");
        Console.WriteLine($"Discount: {discount}");
        */
}
