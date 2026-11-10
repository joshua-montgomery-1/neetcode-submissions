public class Solution {
    public int ClimbStairs(int n) {
        return CountWays(n, 1, 1);
    }

    public int CountWays(int remaining, int previousWays, int currentWays)
    {
        if (remaining == 1) return currentWays;

        return CountWays(
            remaining - 1,
            currentWays,
            previousWays + currentWays
        );
    }
}