public class Solution {
    public int ClimbStairs(int n) {
        return Times(n, 1, 1);
    }

    public int Times(int remaining, int one, int two)
    {
        if (remaining == 1) return two;

        return Times(remaining - 1, two, one + two);
    }
}