namespace LeetCodeTasks.Tasks;

public class Task11
{
    public int MaxArea(int[] height)
    {
        int leftPointer = 0;
        int rightPointer = height.Length - 1;
        int maxSquare = 0;
        var minHeight = 0;
        var width = 0;
        var currentSquare = 0;

        while (leftPointer < rightPointer)
        {
            minHeight = height[leftPointer] > height[rightPointer] ? height[rightPointer] : height[leftPointer];
            width = rightPointer - leftPointer;
            currentSquare = minHeight * width;
            if (maxSquare < (minHeight * width))
                maxSquare = currentSquare;

            if (height[leftPointer] > height[rightPointer])
                rightPointer--;
            else
                leftPointer++;
        }

        return maxSquare;
    }
}