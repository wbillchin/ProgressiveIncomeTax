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
        double totalTax = CalculateTax(income, brackets, rates);

        // Calculate taxes due
        double taxesDue = totalTax - payrollTaxesPaid;

        // Display results
        Console.WriteLine($"\nTotal federal tax on an income of {income:C} is {totalTax:C}");

        if (taxesDue > 0)
        {
            Console.WriteLine($"You owe {taxesDue:C} in taxes.");
        } else
        {
            Console.WriteLine($"You are due a refund of {-taxesDue:C}.");
        }

    }

    static double CalculateTax(double income, double[] brackets, double[] rates)
    {
        double tax = 0;
        double previousBracketLimit = 0;

        // Loop through each bracket
        for (int bracketCounter = 0; bracketCounter < brackets.Length; bracketCounter++)
        {
            if (income > brackets[bracketCounter])
            {
                // Tax the amount within this bracket
                tax += (brackets[bracketCounter] - previousBracketLimit) * rates[bracketCounter];
                previousBracketLimit = brackets[bracketCounter];
            }
            else
            {
                // If income falls within this bracket
                tax += (income - previousBracketLimit) * rates[bracketCounter];
                return tax;
            }
        }

        // Tax the remaining income (if it exceeds the last bracket)
        if (income > previousBracketLimit)
        {
            tax += (income - previousBracketLimit) * rates[brackets.Length];
        }

        return tax;
    }
}