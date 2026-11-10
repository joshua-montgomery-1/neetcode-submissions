public class Solution {
    public List<List<Pair>> InsertionSort(List<Pair> pairs) {
        List<List<Pair>> states = new List<List<Pair>>();

        states.Add(new List<Pair>(pairs));

        int length = pairs.Count;

        if(length == 0) return new List<List<Pair>>();

        for (int i = 1; i < length; i++)
        {
            int j = i - 1;

            while (j >= 0 && pairs[j].Key > pairs[j + 1].Key)
            {
                var item1 = pairs[j];
                var item2 = pairs[j + 1];

                pairs[j + 1] = item1;
                pairs[j] = item2;

                j--;
            }

            states.Add(new List<Pair>(pairs));
        }

        return states;
    }
}