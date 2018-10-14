using System;
using Microsoft.EntityFrameworkCore;
using SbDbLib.DB;

namespace SbDbLib
{
    internal class SbDbContext : DbContext
    {
        public SbDbContext()
        {
        }

        public SbDbContext(DbContextOptions<SbDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<AccountLog> AccountLog { get; set; }
        public virtual DbSet<AccountTrans> AccountTrans { get; set; }
        public virtual DbSet<Bill> Bill { get; set; }
        public virtual DbSet<Budget> Budget { get; set; }
        public virtual DbSet<BudgetFuture> BudgetFuture { get; set; }
        public virtual DbSet<BudgetHistory> BudgetHistory { get; set; }
        public virtual DbSet<BudgetSettings> BudgetSettings { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Currency> Currency { get; set; }
        public virtual DbSet<DeviceInfo> DeviceInfo { get; set; }
        public virtual DbSet<Expense> Expense { get; set; }
        public virtual DbSet<Fihints> Fihints { get; set; }
        public virtual DbSet<Fitrans> Fitrans { get; set; }
        public virtual DbSet<Income> Income { get; set; }
        public virtual DbSet<Payee> Payee { get; set; }
        public virtual DbSet<RecurringBill> RecurringBill { get; set; }
        public virtual DbSet<RecurringExpense> RecurringExpense { get; set; }
        public virtual DbSet<RecurringIncome> RecurringIncome { get; set; }
        public virtual DbSet<RecurringTransfer> RecurringTransfer { get; set; }
        public virtual DbSet<Settings> Settings { get; set; }
        public virtual DbSet<SubCategory> SubCategory { get; set; }
        public virtual DbSet<SyncUpdate> SyncUpdate { get; set; }
        public virtual DbSet<Transfer> Transfer { get; set; }

        // Unable to generate entity type for table 'SyncInfo'. Please see the warning messages.
        // Unable to generate entity type for table 'android_metadata'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlite("Filename=homebudget.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.HasIndex(e => new { e.DeviceIdKey, e.DeviceKey })
                    .HasName("AccountDeviceIdDeviceKeyIndex");

                entity.Property(e => e.Key)
                    .HasColumnName("key")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountType).HasColumnName("accountType");

                entity.Property(e => e.Balance)
                    .HasColumnName("balance")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.BalanceDate)
                    .HasColumnName("balanceDate")
                    .HasColumnType("DATE");

                entity.Property(e => e.Currency).HasColumnName("currency");

                entity.Property(e => e.DeleteOk)
                    .HasColumnName("deleteOK")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'Y'");

                entity.Property(e => e.DeviceIdKey).HasColumnName("deviceIdKey");

                entity.Property(e => e.DeviceKey).HasColumnName("deviceKey");

                entity.Property(e => e.Icon).HasColumnName("icon");

                entity.Property(e => e.IncludeAccount)
                    .HasColumnName("includeAccount")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'Y'");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.SeqNum)
                    .HasColumnName("seqNum")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<AccountLog>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.HasIndex(e => e.AccountKey)
                    .HasName("AccountLogAccountKeyIndex");

                entity.HasIndex(e => e.TimeStamp)
                    .HasName("AccountLogTimeStampIndex");

                entity.Property(e => e.Key)
                    .HasColumnName("key")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountKey).HasColumnName("accountKey");

                entity.Property(e => e.Checked)
                    .HasColumnName("checked")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.NewBalance).HasColumnName("newBalance");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("timeStamp")
                    .HasColumnType("DATETIME");

                entity.Property(e => e.TransAmount).HasColumnName("transAmount");

                entity.Property(e => e.TransDate)
                    .HasColumnName("transDate")
                    .HasColumnType("DATE");

                entity.Property(e => e.TransKey).HasColumnName("transKey");

                entity.Property(e => e.TransType).HasColumnName("transType");
            });

            modelBuilder.Entity<AccountTrans>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.HasIndex(e => e.TransDate)
                    .HasName("AccountTransTransDateIndex");

                entity.HasIndex(e => new { e.TransType, e.TransKey })
                    .HasName("AccountTransTransKeyIndex");

                entity.Property(e => e.Key)
                    .HasColumnName("key")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountKey).HasColumnName("accountKey");

                entity.Property(e => e.Checked)
                    .HasColumnName("checked")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("timeStamp")
                    .HasColumnType("DATETIME");

                entity.Property(e => e.TransAmount).HasColumnName("transAmount");

                entity.Property(e => e.TransDate)
                    .HasColumnName("transDate")
                    .HasColumnType("DATE");

                entity.Property(e => e.TransKey).HasColumnName("transKey");

                entity.Property(e => e.TransType).HasColumnName("transType");
            });

            modelBuilder.Entity<Bill>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.HasIndex(e => e.DueDate)
                    .HasName("BillsDueDateIndex");

                entity.HasIndex(e => new { e.DeviceIdKey, e.DeviceKey })
                    .HasName("BillDeviceIdDeviceKeyIndex");

                entity.Property(e => e.Key)
                    .HasColumnName("key")
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.BillType)
                    .HasColumnName("billType")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CatKey)
                    .HasColumnName("catKey")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Currency).HasColumnName("currency");

                entity.Property(e => e.CurrencyAmount).HasColumnName("currencyAmount");

                entity.Property(e => e.DeviceIdKey).HasColumnName("deviceIdKey");

                entity.Property(e => e.DeviceKey).HasColumnName("deviceKey");

                entity.Property(e => e.DueDate)
                    .HasColumnName("dueDate")
                    .HasColumnType("DATE");

                entity.Property(e => e.ExpenseKey).HasColumnName("expenseKey");

                entity.Property(e => e.FromAccountKey)
                    .HasColumnName("fromAccountKey")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.Paid)
                    .HasColumnName("paid")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'Y'");

                entity.Property(e => e.PayeeKey).HasColumnName("payeeKey");

                entity.Property(e => e.RecurringKey)
                    .HasColumnName("recurringKey")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SubCatKey)
                    .HasColumnName("subCatKey")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("timeStamp")
                    .HasColumnType("DATETIME");
            });

            modelBuilder.Entity<Budget>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.HasIndex(e => new { e.CatKey, e.SubCatKey, e.Month, e.Year })
                    .HasName("BudgetCatKeySubCatKeyMonthYearIndex");

                entity.Property(e => e.Key)
                    .HasColumnName("key")
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.CatKey).HasColumnName("catKey");

                entity.Property(e => e.Month).HasColumnName("month");

                entity.Property(e => e.SubCatKey).HasColumnName("subCatKey");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<BudgetFuture>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.HasIndex(e => new { e.SubCatKey, e.StartDate, e.EndDate })
                    .HasName("BudgetFutureSubCatStartDateEndDateIndex");

                entity.Property(e => e.Key)
                    .HasColumnName("key")
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.CatKey).HasColumnName("catKey");

                entity.Property(e => e.Cycle).HasColumnName("cycle");

                entity.Property(e => e.EndDate)
                    .HasColumnName("endDate")
                    .HasColumnType("DATE");

                entity.Property(e => e.StartDate)
                    .HasColumnName("startDate")
                    .HasColumnType("DATE");

                entity.Property(e => e.SubCatKey).HasColumnName("subCatKey");
            });

            modelBuilder.Entity<BudgetHistory>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.Property(e => e.Key)
                    .HasColumnName("key")
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.BudgetType)
                    .HasColumnName("budgetType")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'E'");

                entity.Property(e => e.CatKey).HasColumnName("catKey");

                entity.Property(e => e.EndDate)
                    .HasColumnName("endDate")
                    .HasColumnType("DATE");

                entity.Property(e => e.RolloverBalance).HasColumnName("rolloverBalance");

                entity.Property(e => e.RolloverOnOff)
                    .HasColumnName("rolloverOnOff")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.StartDate)
                    .HasColumnName("startDate")
                    .HasColumnType("DATE");

                entity.Property(e => e.SubCatKey).HasColumnName("subCatKey");
            });

            modelBuilder.Entity<BudgetSettings>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.Property(e => e.Key)
                    .HasColumnName("key")
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.BudgetType)
                    .HasColumnName("budgetType")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'E'");

                entity.Property(e => e.CatKey).HasColumnName("catKey");

                entity.Property(e => e.Cycle).HasColumnName("cycle");

                entity.Property(e => e.DeviceIdKey).HasColumnName("deviceIdKey");

                entity.Property(e => e.DeviceKey).HasColumnName("deviceKey");

                entity.Property(e => e.EndDate)
                    .HasColumnName("endDate")
                    .HasColumnType("DATE");

                entity.Property(e => e.Modulus).HasColumnName("modulus");

                entity.Property(e => e.RolloverBalance).HasColumnName("rolloverBalance");

                entity.Property(e => e.RolloverOnOff)
                    .HasColumnName("rolloverOnOff")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.StartDate)
                    .HasColumnName("startDate")
                    .HasColumnType("DATE");

                entity.Property(e => e.SubCatKey).HasColumnName("subCatKey");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.Property(e => e.Key)
                    .HasColumnName("key")
                    .ValueGeneratedNever();

                entity.Property(e => e.DeleteOk)
                    .HasColumnName("deleteOK")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.DeviceIdKey).HasColumnName("deviceIdKey");

                entity.Property(e => e.DeviceKey).HasColumnName("deviceKey");

                entity.Property(e => e.Icon).HasColumnName("icon");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.SeqNum)
                    .HasColumnName("seqNum")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Currency>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.Property(e => e.Key)
                    .HasColumnName("key")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.ExchangeRate).HasColumnName("exchangeRate");

                entity.Property(e => e.Locale).HasColumnName("locale");

                entity.Property(e => e.Name).HasColumnName("name");
            });

            modelBuilder.Entity<DeviceInfo>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.HasIndex(e => e.DeviceId)
                    .HasName("DeviceInfoDeviceIdIndex");

                entity.Property(e => e.Key)
                    .HasColumnName("key")
                    .ValueGeneratedNever();

                entity.Property(e => e.DeviceId).HasColumnName("deviceId");

                entity.Property(e => e.DeviceName).HasColumnName("deviceName");

                entity.Property(e => e.IsActive)
                    .HasColumnName("isActive")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.IsPrimary)
                    .HasColumnName("isPrimary")
                    .HasColumnType("CHAR(1)");
            });

            modelBuilder.Entity<Expense>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.HasIndex(e => e.Date)
                    .HasName("ExpenseDateIndex");

                entity.HasIndex(e => new { e.DeviceIdKey, e.DeviceKey })
                    .HasName("ExpenseDeviceIdDeviceKeyIndex");

                entity.Property(e => e.Key)
                    .HasColumnName("key")
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.BillKey)
                    .HasColumnName("billKey")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CatKey).HasColumnName("catKey");

                entity.Property(e => e.Currency).HasColumnName("currency");

                entity.Property(e => e.CurrencyAmount).HasColumnName("currencyAmount");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("DATE");

                entity.Property(e => e.DeviceIdKey).HasColumnName("deviceIdKey");

                entity.Property(e => e.DeviceKey).HasColumnName("deviceKey");

                entity.Property(e => e.IncludesReceipt)
                    .HasColumnName("includesReceipt")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.IsCategorySplit)
                    .HasColumnName("isCategorySplit")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.IsDetailEntry)
                    .HasColumnName("isDetailEntry")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.MasterKey).HasColumnName("masterKey");

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.PayFrom)
                    .HasColumnName("payFrom")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PayeeKey)
                    .HasColumnName("payeeKey")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Periods).HasColumnName("periods");

                entity.Property(e => e.RecurringKey)
                    .HasColumnName("recurringKey")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SubCatKey).HasColumnName("subCatKey");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("timeStamp")
                    .HasColumnType("DATETIME");
            });

            modelBuilder.Entity<Fihints>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.ToTable("FIHints");

                entity.HasIndex(e => new { e.AccountKey, e.Name, e.TrnType })
                    .HasName("FIHintsNameIndex");

                entity.Property(e => e.Key)
                    .HasColumnName("key")
                    .ValueGeneratedNever();

                entity.Property(e => e.Account2Key).HasColumnName("account2Key");

                entity.Property(e => e.AccountKey).HasColumnName("accountKey");

                entity.Property(e => e.CatKey).HasColumnName("catKey");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.PayeeKey).HasColumnName("payeeKey");

                entity.Property(e => e.ProcessAs).HasColumnName("processAs");

                entity.Property(e => e.SubCatKey).HasColumnName("subCatKey");

                entity.Property(e => e.TrnType).HasColumnName("trnType");
            });

            modelBuilder.Entity<Fitrans>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.ToTable("FITrans");

                entity.HasIndex(e => new { e.AccountKey, e.FiTid })
                    .HasName("FITransFiTIDIndex");

                entity.Property(e => e.Key)
                    .HasColumnName("key")
                    .ValueGeneratedNever();

                entity.Property(e => e.Account2Key).HasColumnName("account2Key");

                entity.Property(e => e.AccountKey).HasColumnName("accountKey");

                entity.Property(e => e.CatKey).HasColumnName("catKey");

                entity.Property(e => e.DatePosted).HasColumnName("datePosted");

                entity.Property(e => e.FiTid).HasColumnName("fiTID");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.PayeeKey).HasColumnName("payeeKey");

                entity.Property(e => e.ProcessAs).HasColumnName("processAs");

                entity.Property(e => e.ProcessState)
                    .HasColumnName("processState")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'U'");

                entity.Property(e => e.Sic).HasColumnName("sic");

                entity.Property(e => e.SubCatKey).HasColumnName("subCatKey");

                entity.Property(e => e.TrnAmount).HasColumnName("trnAmount");

                entity.Property(e => e.TrnType).HasColumnName("trnType");
            });

            modelBuilder.Entity<Income>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.HasIndex(e => e.Date)
                    .HasName("IncomeDate");

                entity.HasIndex(e => new { e.DeviceIdKey, e.DeviceKey })
                    .HasName("IncomeDeviceIdDeviceKeyIndex");

                entity.Property(e => e.Key)
                    .HasColumnName("key")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddIncomeTo)
                    .HasColumnName("addIncomeTo")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.Currency).HasColumnName("currency");

                entity.Property(e => e.CurrencyAmount).HasColumnName("currencyAmount");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("DATE");

                entity.Property(e => e.DeviceIdKey).HasColumnName("deviceIdKey");

                entity.Property(e => e.DeviceKey).HasColumnName("deviceKey");

                entity.Property(e => e.MasterKey).HasColumnName("masterKey");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.RecurringKey)
                    .HasColumnName("recurringKey")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("timeStamp")
                    .HasColumnType("DATETIME");
            });

            modelBuilder.Entity<Payee>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.HasIndex(e => new { e.DeviceIdKey, e.DeviceKey })
                    .HasName("PayeeDeviceIdDeviceKeyIndex");

                entity.Property(e => e.Key)
                    .HasColumnName("key")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountNum).HasColumnName("accountNum");

                entity.Property(e => e.DeviceIdKey).HasColumnName("deviceIdKey");

                entity.Property(e => e.DeviceKey).HasColumnName("deviceKey");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.PhoneNum).HasColumnName("phoneNum");

                entity.Property(e => e.WebUrl).HasColumnName("webURL");
            });

            modelBuilder.Entity<RecurringBill>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.Property(e => e.Key)
                    .HasColumnName("key")
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.BillType)
                    .HasColumnName("billType")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CatKey)
                    .HasColumnName("catKey")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Currency).HasColumnName("currency");

                entity.Property(e => e.CurrencyAmount).HasColumnName("currencyAmount");

                entity.Property(e => e.DeviceIdKey).HasColumnName("deviceIdKey");

                entity.Property(e => e.DeviceKey).HasColumnName("deviceKey");

                entity.Property(e => e.EndDate)
                    .HasColumnName("endDate")
                    .HasColumnType("DATE");

                entity.Property(e => e.FromAccountKey)
                    .HasColumnName("fromAccountKey")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GenerateNow)
                    .HasColumnName("generateNow")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.Modulus).HasColumnName("modulus");

                entity.Property(e => e.NextGenDate)
                    .HasColumnName("nextGenDate")
                    .HasColumnType("DATE");

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.PayeeOrAccountKey).HasColumnName("payeeOrAccountKey");

                entity.Property(e => e.RecurringIndex).HasColumnName("recurringIndex");

                entity.Property(e => e.SubCatKey)
                    .HasColumnName("subCatKey")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<RecurringExpense>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.Property(e => e.Key)
                    .HasColumnName("key")
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.CatKey).HasColumnName("catKey");

                entity.Property(e => e.Currency).HasColumnName("currency");

                entity.Property(e => e.CurrencyAmount).HasColumnName("currencyAmount");

                entity.Property(e => e.DeviceIdKey).HasColumnName("deviceIdKey");

                entity.Property(e => e.DeviceKey).HasColumnName("deviceKey");

                entity.Property(e => e.EndDate)
                    .HasColumnName("endDate")
                    .HasColumnType("DATE");

                entity.Property(e => e.GenerateNow)
                    .HasColumnName("generateNow")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.Modulus).HasColumnName("modulus");

                entity.Property(e => e.NextGenDate)
                    .HasColumnName("nextGenDate")
                    .HasColumnType("DATE");

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.PayFrom).HasColumnName("payFrom");

                entity.Property(e => e.Payee).HasColumnName("payee");

                entity.Property(e => e.SubCatKey).HasColumnName("subCatKey");

                entity.Property(e => e.TimesAyear).HasColumnName("timesAYear");
            });

            modelBuilder.Entity<RecurringIncome>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.Property(e => e.Key)
                    .HasColumnName("key")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddIncomeTo)
                    .HasColumnName("addIncomeTo")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.Currency).HasColumnName("currency");

                entity.Property(e => e.CurrencyAmount).HasColumnName("currencyAmount");

                entity.Property(e => e.DeviceIdKey).HasColumnName("deviceIdKey");

                entity.Property(e => e.DeviceKey).HasColumnName("deviceKey");

                entity.Property(e => e.EndDate)
                    .HasColumnName("endDate")
                    .HasColumnType("DATE");

                entity.Property(e => e.GenerateNow)
                    .HasColumnName("generateNow")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.Modulus).HasColumnName("modulus");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.NextGenDate)
                    .HasColumnName("nextGenDate")
                    .HasColumnType("DATE");

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.StartDate)
                    .HasColumnName("startDate")
                    .HasColumnType("DATE");

                entity.Property(e => e.TimesAyear).HasColumnName("timesAYear");
            });

            modelBuilder.Entity<RecurringTransfer>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.Property(e => e.Key)
                    .HasColumnName("key")
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.Currency).HasColumnName("currency");

                entity.Property(e => e.CurrencyAmount).HasColumnName("currencyAmount");

                entity.Property(e => e.DeviceIdKey).HasColumnName("deviceIdKey");

                entity.Property(e => e.DeviceKey).HasColumnName("deviceKey");

                entity.Property(e => e.EndDate)
                    .HasColumnName("endDate")
                    .HasColumnType("DATE");

                entity.Property(e => e.FromAccount).HasColumnName("fromAccount");

                entity.Property(e => e.GenerateNow)
                    .HasColumnName("generateNow")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.Modulus).HasColumnName("modulus");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.NextGenDate)
                    .HasColumnName("nextGenDate")
                    .HasColumnType("DATE");

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.TimesAyear).HasColumnName("timesAYear");

                entity.Property(e => e.ToAccount).HasColumnName("toAccount");
            });

            modelBuilder.Entity<Settings>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.Property(e => e.Key)
                    .HasColumnName("key")
                    .ValueGeneratedNever();

                entity.Property(e => e.BillLookForward)
                    .HasColumnName("billLookForward")
                    .HasDefaultValueSql("6");

                entity.Property(e => e.BillNotifyHour)
                    .HasColumnName("billNotifyHour")
                    .HasDefaultValueSql("2");

                entity.Property(e => e.ColorScheme)
                    .HasColumnName("colorScheme")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Currency).HasColumnName("currency");

                entity.Property(e => e.Cyclestart).HasColumnName("cyclestart");

                entity.Property(e => e.DateFormat).HasColumnName("dateFormat");

                entity.Property(e => e.DebugFlag).HasColumnName("debugFlag");

                entity.Property(e => e.DeleteExpenseAfter).HasColumnName("deleteExpenseAfter");

                entity.Property(e => e.DeleteReceiptAfter).HasColumnName("deleteReceiptAfter");

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.Future1).HasColumnName("future1");

                entity.Property(e => e.Future10).HasColumnName("future10");

                entity.Property(e => e.Future2).HasColumnName("future2");

                entity.Property(e => e.Future3).HasColumnName("future3");

                entity.Property(e => e.Future4).HasColumnName("future4");

                entity.Property(e => e.Future5).HasColumnName("future5");

                entity.Property(e => e.Future6).HasColumnName("future6");

                entity.Property(e => e.Future7).HasColumnName("future7");

                entity.Property(e => e.Future8).HasColumnName("future8");

                entity.Property(e => e.Future9).HasColumnName("future9");

                entity.Property(e => e.HomeScreenStyle)
                    .HasColumnName("homeScreenStyle")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ImageResolution).HasColumnName("imageResolution");

                entity.Property(e => e.ImportMatchLength)
                    .HasColumnName("importMatchLength")
                    .HasDefaultValueSql("16");

                entity.Property(e => e.IncludeFutureTrans)
                    .HasColumnName("includeFutureTrans")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'Y'");

                entity.Property(e => e.InitialBudget).HasColumnName("initialBudget");

                entity.Property(e => e.KeyBoardClicks)
                    .HasColumnName("keyBoardClicks")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'Y'");

                entity.Property(e => e.LastRun)
                    .HasColumnName("lastRun")
                    .HasColumnType("DATETIME");

                entity.Property(e => e.LastUsedAccount)
                    .HasColumnName("lastUsedAccount")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastUsedPayee)
                    .HasColumnName("lastUsedPayee")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale).HasColumnName("locale");

                entity.Property(e => e.MonthlyCycleStart)
                    .HasColumnName("monthlyCycleStart")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Password).HasColumnName("password");

                entity.Property(e => e.PasswordEmail).HasColumnName("passwordEmail");

                entity.Property(e => e.PasswordOnOff).HasColumnName("passwordOnOff");

                entity.Property(e => e.RolloverStart)
                    .HasColumnName("rolloverStart")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ScreenMajor).HasColumnName("screenMajor");

                entity.Property(e => e.ScreenMicro).HasColumnName("screenMicro");

                entity.Property(e => e.ScreenMini).HasColumnName("screenMini");

                entity.Property(e => e.ShowAmountInNumbers)
                    .HasColumnName("showAmountInNumbers")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.ShowBillBadge)
                    .HasColumnName("showBillBadge")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.ShowBillReminders)
                    .HasColumnName("showBillReminders")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.ShowMonthlyBudgetView)
                    .HasColumnName("showMonthlyBudgetView")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.StartPage)
                    .HasColumnName("startPage")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SubCategory>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.Property(e => e.Key)
                    .HasColumnName("key")
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.AutoGenDay)
                    .HasColumnName("autoGenDay")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.AutoGenExpEntry)
                    .HasColumnName("autoGenExpEntry")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.CatKey).HasColumnName("catKey");

                entity.Property(e => e.DeleteOk)
                    .HasColumnName("deleteOK")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'Y'");

                entity.Property(e => e.DeviceIdKey).HasColumnName("deviceIdKey");

                entity.Property(e => e.DeviceKey).HasColumnName("deviceKey");

                entity.Property(e => e.ExpenseType)
                    .HasColumnName("expenseType")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ForPeriod)
                    .HasColumnName("forPeriod")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Icon).HasColumnName("icon");

                entity.Property(e => e.Modulus).HasColumnName("modulus");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.NextGenDate)
                    .HasColumnName("nextGenDate")
                    .HasColumnType("DATE");

                entity.Property(e => e.PayFrom)
                    .HasColumnName("payFrom")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Payee)
                    .HasColumnName("payee")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RecurExpAmount).HasColumnName("recurExpAmount");

                entity.Property(e => e.SeqNum)
                    .HasColumnName("seqNum")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TimesAyear).HasColumnName("timesAYear");
            });

            modelBuilder.Entity<SyncUpdate>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.Property(e => e.Key)
                    .HasColumnName("key")
                    .ValueGeneratedNever();

                entity.Property(e => e.Payload).HasColumnName("payload");

                entity.Property(e => e.UpdateType).HasColumnName("updateType");

                entity.Property(e => e.Uuid).HasColumnName("uuid");
            });

            modelBuilder.Entity<Transfer>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.Property(e => e.Key)
                    .HasColumnName("key")
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.BillKey)
                    .HasColumnName("billKey")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Currency).HasColumnName("currency");

                entity.Property(e => e.CurrencyAmount).HasColumnName("currencyAmount");

                entity.Property(e => e.DeviceIdKey).HasColumnName("deviceIdKey");

                entity.Property(e => e.DeviceKey).HasColumnName("deviceKey");

                entity.Property(e => e.FromAccount).HasColumnName("fromAccount");

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.RecurringKey)
                    .HasColumnName("recurringKey")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ToAccount).HasColumnName("toAccount");

                entity.Property(e => e.TransferDate)
                    .HasColumnName("transferDate")
                    .HasColumnType("DATE");
            });
        }
    }
}
