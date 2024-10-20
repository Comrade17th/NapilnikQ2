internal class Shop
{
    private readonly Warehouse _warehouse;

    public Shop(Warehouse warehouse) => 
        _warehouse = warehouse;

    public Cart Cart() => 
        new(this);

    public bool Contains(Good good, int count)
    {
        ArgumentNullException.ThrowIfNull(good);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(count);
        return _warehouse.Contains(good, count);
    }

    public void Remove(Good good, int count)
    {
        ArgumentNullException.ThrowIfNull(good);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(count);
        _warehouse.Remove(good, count);
    }
}