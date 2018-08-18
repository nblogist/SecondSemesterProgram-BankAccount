using System;
using System.Runtime.InteropServices;


namespace Bank_Account
{
    public enum Type
    {
       Savings=1,
       Current
    }
    class Bank
    {
        private string name;
        private Type type;
        private Int64 AccNum;
        private int Bal;

        public void Name(string a)
        {
            name = a;
        }

        public void Deposit(int a)
        {
            Bal += a;
        }

        public void Withdraw(int a)
        {
            if (a>Bal)
            {
                Console.WriteLine("Sorry! YOUR ACCOUNT BALANCE IS NOT ENOUGH TO WITHDRAW " +a+" Dollars!");
            }
            else
            {
                Bal -= a;
                Console.WriteLine("Now your remaining balance is "+Bal);
            }
        }

        public void AccType(byte a)
        {
            type = (Type) a;
        }

        public void Display()
        {
            Console.WriteLine("Your name is: "+name);
            Console.WriteLine("Account Type: "+type);
            Console.WriteLine("You account balance is " +Bal);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var obj1=new Bank();
            var obj2 = new Bank();
            var obj3 = new Bank();
            var obj4 = new Bank();
            obj1.Name("Furqan");
            obj1.AccType(1);
            obj1.Deposit(100);
            obj1.Withdraw(50);
            obj1.Display();
        }
    }
}
