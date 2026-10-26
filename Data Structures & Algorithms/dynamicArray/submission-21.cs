public class DynamicArray {
    
    int[] _arr;
    int _length;
    int _capacity;

    private DynamicArray(){}
    public DynamicArray(int capacity) {
        _length = 0;
        _capacity = capacity;
        _arr = new int[_capacity];
    }

    public int? Get(int i) {
        return _arr[i];
    }

    public void Set(int i, int n) {
        _arr[i] = n;
    }

    public void PushBack(int n) {
        if(_length == _capacity)
        {
            Resize();
        }
        _arr[_length] = n;
        _length++;
    }

    public int? PopBack() {
        _length--;
        return _arr[_length];
    }

    private void Resize() {
        _capacity = _capacity * 2;
        var newList = new int[_capacity];

        Array.Copy(_arr, newList, _capacity/2);

        _arr = newList;
    }

    public int GetSize() {
        return _length;
    }

    public int GetCapacity() {
        return _capacity;
    }
}
