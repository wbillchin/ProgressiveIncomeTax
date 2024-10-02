/*
 * INFO 350 - Progressive Income Tax
 */


using System;

class IncomeTaxCalculator
{
    private static int taxesDue;

    static void Main(string[] args)
    {
        // Define US tax brackets and corresponding rates (2024, single filer)
        double[] brackets = { 11610, 47820, 102800, 182100, 231250, 578100 }; // Bracket limits
        double[] rates = { 0.10, 0.12, 0.22, 0.24, 0.32, 0.35, 0.37 };        // Corresponding tax rates

        // Get taxable income from user
        Console.Write("Enter your taxable income: ");
        double income = double.Parse(Console.ReadLine());

        // Get amount already paid in payroll taxes
        Console.Write("Enter the amount already paid in payroll taxes: ");
        double payrollTaxesPaid = double.Parse(Console.ReadLine());

        // Calculate total tax

        // Calculate taxes due

        // Display results
        //Console.WriteLine($"\nTotal federal tax on an income of {income:C} is {totalTax:C}");


        //Console.WriteLine($"You owe {taxesDue:C} in taxes.");

        //Console.WriteLine($"You are due a refund of {-taxesDue:C}.");

    }

    static double CalculateTax(double income, double[] brackets, double[] rates)
    {
        double tax = 0;

        return tax;
    }
}