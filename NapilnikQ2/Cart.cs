using System.Text;

internal class Cart
{
    private Shop _shop;
    private Storage _storage;

    public Cart(Shop shop)
    {
        _shop = shop;
        _storage = new Storage();
    }
    
    public void Add(Good good, int count)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(count);
        ArgumentNullException.ThrowIfNull(good);
        
        if(_shop.Contains(good, count))
            _storage.Add(good, count);
        else
            throw new InvalidOperationException();
    }

    public Order Order()
    {
        var paylink = new StringBuilder();
        
        foreach (KeyValuePair<Good, int> cell in _storage.Cells)
        {
            if (_shop.Contains(cell.Key, cell.Value) == false)
                throw new InvalidOperationException();
        }
        
        foreach (KeyValuePair<Good, int> cell in _storage.Cells)
        {
            paylink.Append($"{cell.Key.Name}:{cell.Value};");
            _shop.Remove(cell.Key, cell.Value);
        }

        return new Order(paylink.ToString());
    }
}