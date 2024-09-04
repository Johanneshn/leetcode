namespace LeetCode;

/*
 * Avoid using any existing stack data structure
 * All operations O(1)
*/
public class _155_MinStack
{
    private (int value, int currentMin)[] _array = new(int,int)[1];
    private int _counter = 0;

    public void Push(int val) {
        if (_counter == _array.Length)
        {
            Array.Resize(ref _array, _array.Length * 2);
        }

        var currentMin = val;
        if (_counter > 0)
        {
            currentMin = Math.Min(val, _array[_counter - 1].currentMin);
        }

        _array[_counter++] = (val, currentMin);
    }

    public void Pop()
    {
        if (_counter > 0)
        {
            _counter--;
        }
    }

    public int Top()
    {
        return _counter == 0 ? 0 : _array[_counter-1].value;
    }

    public int GetMin()
    {
        return _counter == 0 ? 0 : _array[_counter-1].currentMin;
    }
}
