using System;

using System.Collections.Generic;

using System.IO;

namespace ConsoleApp3_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            Account<int> account1 = new Account<int>();
            account1.Write(1, 0.01, "Николас Коппола");

            Account<string> account2 = new Account<string>();
            account2.Write("Номер 1", 0.02, "Николас Коппола");

            account1.Read();
            account2.Read();

            Console.ReadLine();
            Run();
            Environment.Exit(0);
        }

        public class Account<T>
        {
            private T Num { get; set; }
            private double Balance { get; set; }
            private string Name { get; set; }

            public T Read()
            {
                Console.WriteLine("Номер: {0}, Баланс: {1}, Имя: {2}", Num, Balance, Name);
                return default(T);
            }

            public T Write(T Num, double Balance, string Name)
            {
                this.Num = Num;
                this.Balance = Balance;
                this.Name = Name;
                return default(T);
            }
        }


    }
}



