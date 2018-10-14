using System.Collections.Generic;
using System.Linq;

namespace SbDbLib
{
    public class AccountInfo
    {
        public string Name { get; set; }
        public double Balance { get; set; }
    }

    public class SbDbApi
    {
        public SbDbApi()
        {
        }


        public List<AccountInfo> GetAccountInfo()
        {
            var info = new List<AccountInfo>();

            using (var ctx = new SbDbContext())
            {
                foreach (var account in ctx.Account)
                {
                    var incomes = ctx.Income.Where(i => i.AddIncomeTo == account.Key)
                        .Where(i => i.Date >= account.BalanceDate)
                        .Select(i => i.Amount)
                        .Sum();
                    var expenses = ctx.Expense.Where(e => e.PayFrom == account.Key)
                        .Where(e => e.Date >= account.BalanceDate)
                        .Select(e => e.Amount)
                        .Sum();
                    var transIn = ctx.Transfer.Where(t => t.ToAccount == account.Key)
                        .Where(t => t.TransferDate >= account.BalanceDate)
                        .Select(t => t.Amount)
                        .Sum();
                    var transOut = ctx.Transfer.Where(t => t.FromAccount == account.Key)
                        .Where(t => t.TransferDate >= account.BalanceDate)
                        .Select(t => t.Amount)
                        .Sum();
                    var balance = account.Balance + incomes - expenses + transIn - transOut;
                    info.Add(new AccountInfo() { Name = account.Name, Balance = balance ?? 0});
                }
            }

            return info;
        }
    }
}
