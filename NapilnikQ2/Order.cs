internal class Order
{
    public string Paylink { get; }

    public Order(string paylink)
    {
        Paylink = paylink;
    }
}