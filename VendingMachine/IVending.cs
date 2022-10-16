namespace VendingMachine
{
    internal interface IVending
    {
        public void PurchaseProduct();
        public void ShowAll();
        public void InsertMoney();
        public int EndTransaction();

    }
}