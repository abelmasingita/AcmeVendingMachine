namespace AcmeVendingMachine.Server.Services
{
    public class VendingMachineService
    {
        private readonly Dictionary<string, int[]> _coinDenominations;


        public VendingMachineService()
        {
            _coinDenominations = new Dictionary<string, int[]>
            {
                { "USD", new int[] { 1, 5, 10, 25 } }, // US Dollar
                { "GBP", new int[] { 1, 2, 5, 10, 20, 50 } }, // British Pound
            };

        }

        public virtual int[] CalculateChange(string currency, double purchaseAmount, double tenderAmount)
        {
            int[] denominations = _coinDenominations[currency];
            int changeAmount = (int)(Math.Round(tenderAmount - purchaseAmount, 2) * 100); // convert to cents
            List<int> change = new List<int>();

            foreach (int coin in denominations.OrderByDescending(c => c))
            {
                while (changeAmount >= coin)
                {
                    changeAmount -= coin;
                    change.Add(coin);
                }
            }

            if (changeAmount > 0)
            {
                throw new InvalidOperationException("Insufficient change available");
            }

            return change.ToArray();
        }

    }
}
