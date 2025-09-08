public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        var index = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (target <= nums[i])
                return i;

            index = i;
        }

        return index + 1;
    }
}