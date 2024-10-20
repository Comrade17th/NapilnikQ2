public class Storage
{
    private Dictionary<Good, int> _cells;

    public Storage() => 
        _cells = new Dictionary<Good, int>();

    public IReadOnlyDictionary<Good, int> Cells => _cells;
    
    public bool Contains(Good good, int count)
    {
        if (_cells.ContainsKey(good) == false)
            return false;

        return _cells[good] >= count;
    }

    public void Remove(Good good, int count)
    {
        ArgumentNullException.ThrowIfNull(good);
        ArgumentOutOfRangeException.ThrowIfNegative(count);

        if (Contains(good, count))
            _cells[good] -= count;
        else
            throw new ArgumentException();
    }

    public void Add(Good good, int count)
    {
        ArgumentNullException.ThrowIfNull(good);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(count);
        
        if(_cells.TryAdd(good, count) == false)
            _cells[good] += count;
    }
}