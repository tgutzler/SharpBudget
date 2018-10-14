using System;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var api = new SbDbLib.SbDbApi();

            Console.WriteLine("Accounts:");
            var accounts = api.GetAccountInfo();
            accounts.ForEach(a => Console.WriteLine($"{a.Name}: {a.Balance:F2}"));
        }
    }
}
