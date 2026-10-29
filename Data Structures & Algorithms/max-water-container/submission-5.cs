public class Solution {
    public int MaxArea(int[] heights) {
        
        int start = 0;
        int end = heights.Length -1;
        int result = 0;

        while(start != end)
        {
            var y1 = heights[start];
            var y2 = heights[end];
            
            var width = end - start;
            var yMax = Math.Min(y2, y1);
            var area = width * yMax;

            result = Math.Max(result, area);

            if(y1 >= y2)
            {
                end--;
            }
            else
            {
                start++;
            }
        }

        return result;
    }
}
