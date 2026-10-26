public class LinkedList {

    List<int> _list = new List<int>();

    public LinkedList() {

    }

    public int Get(int index) {
        if(index >= _list.Count) return -1;

        return _list[index];
    }

    public void InsertHead(int val) {
        _list.Insert(0, val);
    }

    public void InsertTail(int val) {
        _list.Add(val);
    }

    public bool Remove(int index) {
        if (index >= _list.Count) return false;
        _list.RemoveAt(index);
        return true;
    }

    public List<int> GetValues() {
        return _list;
    }
}