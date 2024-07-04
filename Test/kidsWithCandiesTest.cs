using kidsWithCandies;

namespace Test;

public class kidsWithCandiesTest
{
    [Fact]
    public void Array_1()
    {
        // Arrange
        var solution = new Solution();
        int[] candies = [2, 3, 5, 1, 3];
        var extraCandies = 3;
        List<bool> Output = [true, true, true, false, true];

        // Act
        var result = solution.KidsWithCandies(candies, extraCandies);

        // Assert
        for (int i = 0; i < candies.Length; i++)
        {
            Assert.True(result[i] == Output[i]);
        }
    }

    [Fact]
    public void Array_2()
    {
        // Arrange
        var solution = new Solution();
        int[] candies = [4, 2, 1, 1, 2];
        var extraCandies = 1;
        List<bool> Output = [true, false, false, false, false];

        // Act
        var result = solution.KidsWithCandies(candies, extraCandies);

        // Assert
        for (int i = 0; i < candies.Length; i++)
        {
            Assert.True(result[i] == Output[i]);
        }
    }

    [Fact]
    public void Array_3()
    {
        // Arrange
        var solution = new Solution();
        int[] candies = [12, 1, 12];
        var extraCandies = 10;
        List<bool> Output = [true, false, true];

        // Act
        var result = solution.KidsWithCandies(candies, extraCandies);

        // Assert
        for (int i = 0; i < candies.Length; i++)
        {
            Assert.True(result[i] == Output[i]);
        }
    }
}