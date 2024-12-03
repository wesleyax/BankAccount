using System.Globalization;

namespace Bank {
    internal class Class1 {
        //--------------------------------- PRIVATE ATTRIBUTES ----------------------------------\\
        private string _name;

        //----------------------------- AUTO-IMPLEMENTED PROPERTIES -----------------------------\\
        public int AccountNumber { get; private set; }
        public double Deposit { get; private set; }

        //------------------------------------- CONSTRUCTORS ------------------------------------\\

        public Class1(int accountNumber, string name) {
            AccountNumber = accountNumber;
            _name = name;
            //Deposit = 0;
        }

        public Class1(int accountNumber, string name, double deposit) : this (accountNumber, name) {
            AddDeposit(deposit);
        }

        //---------------------------------- CUSTOM PROPERTIES ----------------------------------\\
        public string Name {
            get { return _name; }
            set {
                if (value != null && value.Length > 4) {
                    _name = value;
                }
            }
        }

        //----------------------------- OTHER METHODS OF THE CLASS ------------------------------\\
        public override string ToString() {
            return "Account number: " + AccountNumber + ", Account name: " + _name + ", Balance: " + Deposit.ToString("F2", CultureInfo.InvariantCulture);
        }
        public void AddDeposit(double amount) {
            Deposit += amount;
        }
        public void Withdrawal(double amount) {
            Deposit -= amount + 5.0;
        }
    }
}
