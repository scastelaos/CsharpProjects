﻿Random random = new Random();
int daysUntilExpiration = random.Next(0 , 12);
int discountPercentage = 0;

if (daysUntilExpiration >= 0)
{
        if (daysUntilExpiration > 10)
        {
        Console.WriteLine("");
        }
        else if (daysUntilExpiration > 5 || daysUntilExpiration == 10)
        {
            Console.WriteLine("Your subscription will expire soon. Renew now!");
        }
        else if (daysUntilExpiration == 5 || daysUntilExpiration > 1)
        {
            Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days. Renew now and save 10%");
            discountPercentage += 10;

        }
        else if (daysUntilExpiration == 1)
        {
            Console.WriteLine("Your subscription expires within a day! Renew now and save 20%");
            discountPercentage += 10;
        }

        else if (daysUntilExpiration == 0)
        {
            Console.WriteLine("Your subscription has expired");
        }
    
}