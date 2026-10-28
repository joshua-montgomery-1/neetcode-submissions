public class LinkedList {
    List<int> list = new List<int>();

    public LinkedList() {
    }

    public int Get(int index) {
        if (index < 0 || index >= list.Count)
            return -1;

        return list[index];
    }

    public void InsertHead(int val) {
        list.Insert(0, val);
    }

    public void InsertTail(int val) {
        list.Add(val);
    }

    public bool Remove(int index) {
        if (index < 0 || index >= list.Count)
            return false;

        list.RemoveAt(index);

        return true;
    }

    public List<int> GetValues() {
        return list;
    }
}