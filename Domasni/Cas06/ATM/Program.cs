using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace ATM
{
    static class Helpers
    {
        public static string Prompt(string question, string[] options = null)
        {
            Console.WriteLine(question);
            options ??= Array.Empty<string>();
            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine("{0,5}. {1}", i + 1, options[i]);
            }
            Console.Write("> ");
            return Console.ReadLine();
        }
        public static string ToDollars(this double val) => val.ToString("C", CultureInfo.GetCultureInfo("en_us"));
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the ATM app");
            ATM atm = new ATM();
            for (; ; )
            {
                atm.Run();
                string again = Helpers.Prompt("Keep running? (Y)/N");
                if (again.ToUpper() == "N") break;
            }
        }

    }


    class ATM
    {
        Customer[] customers =
        {
            new Customer("4325")
            {
                Name = "Bob Bobsky",
                CardNumber = 1234123412341234UL,
                Balance = 650
            },
        };

        Customer CurrentCustomer { get; set; }
        public void Run()
        {
            string register = Helpers.Prompt("Register/(Login)?");
            if(register.ToLower() == "register" || register.ToLower() == "r")
            {
                Register();
                return;
            }
            CurrentCustomer = null;
            string cardNumber = Helpers.Prompt("Please enter your card number:");
            if (!Regex.IsMatch(cardNumber, @"^(\d{4})-(\d{4})-(\d{4})-(\d{4})(\n|$)"))
            {
                Console.WriteLine("Invalid card number!");
                return;
            }
            double normalizedCN = ulong.Parse(cardNumber.Replace("-", ""));
            foreach (var customer in customers)
            {
                if (customer.CardNumber == normalizedCN)
                {
                    CurrentCustomer = customer;
                    break;
                }
            }
            if (CurrentCustomer == null)
            {
                Console.WriteLine("No customer with that card number exists!");
                return;
            }
            string pin = Helpers.Prompt("Please enter your PIN:");
            if (pin != CurrentCustomer.GetPIN())
            {
                Console.WriteLine("You entered an incorrect PIN!");
                return;
            }

            Console.WriteLine("Welcome {0}!", CurrentCustomer.Name);
            for(; ; )
            {
                DoSomething();
                string again = Helpers.Prompt("Do another transaction? (Y)/N");
                if (again.ToUpper() == "N") break;
            }

            Console.WriteLine("Thank you for using the ATM app.");
        }

        void Register()
        {
            // card number

            ulong cn;
            for(; ;)
            {
                cn = ((ulong)(new Random().Next()) << 32) + (ulong)(new Random().Next());
                cn %= (ulong)1e16;

                bool exists = false;
                foreach(var c in customers)
                {
                    if(c.CardNumber == cn)
                    {
                        exists = true;
                        break;
                    }
                }
                if (!exists) break;
            }

            // name

            string fullName = Helpers.Prompt("Enter full name:");

            // pin

            string pin = Helpers.Prompt("Enter PIN:");
            if(!Regex.IsMatch(pin, @"^\d{4}(\n|$)"))
            {
                Console.WriteLine("Invalid PIN");
                return;
            }

            Array.Resize(ref customers, customers.Length + 1);
            customers[customers.Length - 1] = new Customer(pin)
            {
                Name = fullName,
                CardNumber = cn,
                Balance = 0
            };

            Console.WriteLine("Successfully created new account with card number {0}!", cn.ToString("####-####-####-####"));
        }

        void DoSomething()
        {
            string doThis = Helpers.Prompt("What would you like to do:", new string[] {
                "Check Balance",
                "Cash Withdrawal",
                "Cash Deposit"
            });

            switch (doThis)
            {
                case "1":
                    // check balance
                    Console.WriteLine("Your balance is {0}.", CurrentCustomer.Balance.ToDollars());
                    break;
                case "2":
                    {
                        if (!double.TryParse(Helpers.Prompt("What's your withdrawal?"), out double val) || val <= 0)
                        {
                            Console.WriteLine("Invalid value!");
                            break;
                        }
                        if (!CurrentCustomer.UpdateBalance(-val))
                        {
                            Console.WriteLine("You don't have enough money on your account!");
                            break;
                        }

                        Console.WriteLine("Successfully withdrawn {0}. You have {1} left.", val.ToDollars(), CurrentCustomer.Balance.ToDollars());
                    }
                    break;
                case "3":
                    {
                        if (!double.TryParse(Helpers.Prompt("What's your deposit?"), out double val) || val <= 0)
                        {
                            Console.WriteLine("Invalid value!");
                            break;
                        }

                        CurrentCustomer.UpdateBalance(val);
                        Console.WriteLine("Successfully deposited {0}. Your new balance is {1}.", val.ToDollars(), CurrentCustomer.Balance.ToDollars());
                    }
                    break;
                default:
                    Console.WriteLine("You entered an invalid choice!");
                    return;
            }
        }
    }

    class Customer
    {
        public Customer(string PIN) : this()
        {
            Pin = PIN;
        }

        Customer()
        {
        }

        public string Name { get; set; }
        public ulong CardNumber { get; set; }
        private string Pin { get; set; }
        public double Balance { get; internal set; }

        public bool UpdateBalance(double change)
        {
            if (Balance + change < 0) return false;
            Balance += change;
            return true;
        }

        public string GetPIN() => Pin;
    }
}
