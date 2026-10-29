public class Solution {
    public int Trap(int[] height) {
        var currentLowestPoint = 0;
        var runningTotal = 0;
        var currentTotal = 0;
        var lastBoundary = 0;

        for (int cursor = 0; cursor < height.Length; cursor++) {
            var currentHeight = height[cursor];

            if (currentHeight >= currentLowestPoint) {
                currentLowestPoint = currentHeight;
                runningTotal += currentTotal;
                currentTotal = 0;
                lastBoundary = cursor;
                continue;
            }

            currentTotal += currentLowestPoint - currentHeight;
        }

        // Process remaining bars from right to left
        currentLowestPoint = 0;
        currentTotal = 0;

        for (int cursor = height.Length - 1; cursor >= lastBoundary; cursor--) {
            var currentHeight = height[cursor];

            if (currentHeight >= currentLowestPoint) {
                currentLowestPoint = currentHeight;
                runningTotal += currentTotal;
                currentTotal = 0;
                continue;
            }

            currentTotal += currentLowestPoint - currentHeight;
        }

        return runningTotal;
    }
}