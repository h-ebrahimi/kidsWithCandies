namespace kidsWithCandies;

public class Solution
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        var max = 0;
        for (int i = 0; i < candies.Length; i++)
        {
            if (max < candies[i]) max = candies[i];
        }

        var result = new List<bool>();
        for (int i = 0; i < candies.Length; i++)
            result.Add(max < (candies[i] + extraCandies));
        return result;
    }
}