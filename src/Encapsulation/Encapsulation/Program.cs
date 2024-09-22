using Encapsulation.Invoicing;
using Encapsulation.Employment;
using System;
using Encapsulation.Calendar;
using Encapsulation.Banking;
using Encapsulation.Extra;

namespace Encapsulation;

public class Program
{
    static void Main(string[] args)
    {
        // INVOICING
        Invoice invoice1 = new Invoice("001", "Hammer", 5, 75.0);
        Console.WriteLine($"Part Number: {invoice1.PartNumber}");
        Console.WriteLine($"Part Description: {invoice1.PartDescription}");
        Console.WriteLine($"Quantity: {invoice1.Quantity}");
        Console.WriteLine($"Price per item: {invoice1.Price}");
        Console.WriteLine($"Total Invoice Amount: {invoice1.GetInvoiceAmount()}");

        // EMPLOYEE
        Employee employee1 = new Employee("John", "Doe", 3000.0);
        Employee employee2 = new Employee("Jane", "Doe", 3500.0);

        Console.WriteLine($"Yearly Salary of {employee1.FirstName} {employee1.LastName}: {employee1.GetYearlySalary()}");
        Console.WriteLine($"Yearly Salary of {employee2.FirstName} {employee2.LastName}: {employee2.GetYearlySalary()}");

        // Raise salary by 10%
        employee1.RaiseSalary(10);
        employee2.RaiseSalary(10);

        Console.WriteLine($"Yearly Salary after 10% raise for {employee1.FirstName} {employee1.LastName}: {employee1.GetYearlySalary()}");
        Console.WriteLine($"Yearly Salary after 10% raise for {employee2.FirstName} {employee2.LastName}: {employee2.GetYearlySalary()}");

        // DATE
        Date validDate = new Date(12, 15, 2021);
        Date invalidDate = new Date(13, 32, 2021); // Ini akan diset ke 1/1/1970

        Console.WriteLine("Valid date:");
        validDate.DisplayDate();
        Console.WriteLine("Invalid date set to default:");
        invalidDate.DisplayDate();

        // BANKING
        BankAccount account = new BankAccount("123456789", "John Doe", 1000.0);
        Console.WriteLine($"Initial balance: {account.GetBalance()}");

        account.Deposit(500.0);
        Console.WriteLine($"Balance after deposit: {account.GetBalance()}");

        account.Withdraw(200.0);
        Console.WriteLine($"Balance after withdrawal: {account.GetBalance()}");

        // EXTRA
        // Dengan data valid
        Idols group1 = new Idols("GFriend", 2015, 6, 14, 120, 136457153);
        group1.GetInfoGroup();
        Console.WriteLine($"Check total songs (calculate): {group1.AllSongs()}");
        Console.WriteLine($"!!! INFORMATION UPDATE !!!");
        group1.GetInfoGroup();

        // Dengan data tidak valid
        Idols group2 = new Idols("", 2004, 14, 11, -4, -10);
        group2.GetInfoGroup();
        Console.WriteLine($"Check total songs (calculate): {group2.AllSongs()}");
        Console.WriteLine($"!!! INFORMATION UPDATE !!!");
        group2.GetInfoGroup();
    }
}
