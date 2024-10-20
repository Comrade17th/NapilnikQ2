internal class Warehouse
{
    private Storage _storage;

    public Warehouse()
    {
        _storage = new Storage();
    }

    public bool Contains(Good good, int count)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(count);
        ArgumentNullException.ThrowIfNull(good);
        return _storage.Contains(good, count);
    }
    
    public void Delive(Good good, int count)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(count);
        ArgumentNullException.ThrowIfNull(good);
        _storage.Add(good, count);
    }

    public void Remove(Good good, int count)
    {
        ArgumentNullException.ThrowIfNull(good);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(count);
        _storage.Remove(good, count);
    }
}