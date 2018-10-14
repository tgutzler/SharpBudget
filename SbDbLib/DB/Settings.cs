using System;
using System.Collections.Generic;

namespace SbDbLib.DB
{
    internal class Settings
    {
        public long Key { get; set; }
        public long? Cyclestart { get; set; }
        public string LastRun { get; set; }
        public string Currency { get; set; }
        public double? InitialBudget { get; set; }
        public string Email { get; set; }
        public string Locale { get; set; }
        public string DateFormat { get; set; }
        public long? ImageResolution { get; set; }
        public long? DeleteExpenseAfter { get; set; }
        public long? DeleteReceiptAfter { get; set; }
        public long? DebugFlag { get; set; }
        public long? ScreenMajor { get; set; }
        public long? ScreenMini { get; set; }
        public long? ScreenMicro { get; set; }
        public long? PasswordOnOff { get; set; }
        public string Password { get; set; }
        public string PasswordEmail { get; set; }
        public string Future1 { get; set; }
        public string Future2 { get; set; }
        public string Future3 { get; set; }
        public string Future4 { get; set; }
        public string Future5 { get; set; }
        public string Future6 { get; set; }
        public string Future7 { get; set; }
        public string Future8 { get; set; }
        public string Future9 { get; set; }
        public string Future10 { get; set; }
        public long? LastUsedAccount { get; set; }
        public long? ColorScheme { get; set; }
        public long? LastUsedPayee { get; set; }
        public long? MonthlyCycleStart { get; set; }
        public string RolloverStart { get; set; }
        public string ShowBillReminders { get; set; }
        public string ShowBillBadge { get; set; }
        public long? StartPage { get; set; }
        public string IncludeFutureTrans { get; set; }
        public string ShowMonthlyBudgetView { get; set; }
        public string KeyBoardClicks { get; set; }
        public long? BillLookForward { get; set; }
        public long? BillNotifyHour { get; set; }
        public string ShowAmountInNumbers { get; set; }
        public long? ImportMatchLength { get; set; }
        public long? HomeScreenStyle { get; set; }
    }
}
