﻿

Console.WriteLine("Provide total:");
int userInput = Int32.Parse(Console.ReadLine());
double discount = CalculateDiscount(userInput);
Console.WriteLine($"Your discount is: {discount}%");
double newTotal = CalculateNewTotal(userInput, discount);
Console.WriteLine($"your updated total with{discount}%: {newTotal}"); newTotal = newTotal / 100;
static double CalculateDiscount(int total)
{
    if (total < 10)
    {
        return 1;
    }
    else if (total >= 10 && total < 20)
    {
        return 5;
    }
    else
    {
        return 10;
    }
}
static double CalculateNewTotal(double total, double discount)
{
    double resault = total - (discount * total) / 100;
    return resault;
}
