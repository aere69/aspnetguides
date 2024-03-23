namespace StructExtensions
{
    public struct Account
    {
        public uint id;
        public float balance;
        private int secret;
    }

    public static class AccountExtensions
    {
        public static void Deposit(ref this Account account, float amount)
        {
            account.balance += amount;

            //This would return an error.
            //Cannot access privatae members
            // account.secret = 1;
        }
    }
}