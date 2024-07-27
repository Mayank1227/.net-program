using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    class BankImfo

    {
        public int Id;
        public string Name;
        public float Salary;
        public string BankName;
        public string BankAccount;
        public string AccountHolderName;
        public string AccountType;
        public string BankManager;
        public string BankEmployee;

        public BankImfo(int id, string name, float salary, string bankName, string bankAccount, string accountHolderName, string accountType, string bankManager, string bankEmployee)  // Parameterized constructor
        {
            Id = id; 
            Name = name;
            Salary = salary;
            BankName = bankName;
            BankAccount = bankAccount;
            AccountHolderName = accountHolderName;
            AccountType = accountType;
            BankManager = bankManager;
            BankEmployee = bankEmployee;
        }

        public void Display()
        {
            Console.WriteLine("Employee ID: " + Id);
            Console.WriteLine("Employee Name: " + Name);
            Console.WriteLine("Employee Salary: " + Salary);
            Console.WriteLine("Bank Name: " + BankName);
            Console.WriteLine("Bank Account: " + BankAccount);
            Console.WriteLine("Account Holder Name: " + AccountHolderName);
            Console.WriteLine("Account Type: " + AccountType);
            Console.WriteLine("Bank Manager: " + BankManager);
            Console.WriteLine("Bank Employee: " + BankEmployee);
        }

        static void Main(string[] args)
        {
           
            BankImfo obj2 = new BankImfo(1009, "Mayank Patel", 22800.30f, " SbiBank", "1234567890", "Mayank Patel", "Savings", "vihnu Patel", "Jigar Patel");
            obj2.Display();

            Console.ReadKey();
        }
    }
}

