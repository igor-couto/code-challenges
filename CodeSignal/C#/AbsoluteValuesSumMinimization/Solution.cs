namespace AbsoluteValuesSumMinimization;

public static class Solution 
{
    public static int AbsoluteValuesSumMinimization_Naive(int[] array)
    {
        var lastSum = 0;
        var result = array[0];

        for (var i = 0; i < array.Length; i++)
            lastSum += Math.Abs(array[i] - array[0]);

        for (var i = 0; i < array.Length; i++)
        {
            var currentSum = 0;
            var currentX = array[i];
            for (var j = 0; j < array.Length; j++)
            {
                currentSum += Math.Abs(array[j] - currentX);
            }
            
            if(currentSum < lastSum)
            {
                lastSum = currentSum;
                result = currentX;
            }
        }
        return result;
    }

    public static int AbsoluteValuesSumMinimization_SecondAttempt(int[] array)
    {
        var minimizedSum = int.MaxValue;
        var result = array[0];

        for (var i = 0; i < array.Length; i++)
        {
            var x = array[i];
            var currentSum = array.Sum( element => Math.Abs(element - x) );

            if(currentSum < minimizedSum)
            {
                minimizedSum = currentSum;
                result = x;
            }
        }
        return result;
    }

    public static int AbsoluteValuesSumMinimization_NaiveButALittleBetter(int[] array)
    {
        var minimizedSum = int.MaxValue;
        var result = array[0];

        for (var i = 0; i < array.Length; i++)
        {
            var currentSum = 0;
            var x = array[i];

            for (var j = 0; j < array.Length; j++)
                currentSum += Math.Abs(array[j] - x);

            if (currentSum < minimizedSum)
            {
                minimizedSum = currentSum;
                result = x;
            }
        }
        return result;
    }

    public static int AbsoluteValuesSumMinimization_BestSolution(int[] array)
    {
        int lenght = array.Length;

        if (lenght % 2 == 1)
        {
            return array[lenght / 2];
        }
        else
        {
            var middle1 = array[(lenght - 1) / 2];
            var middle2 = array[lenght / 2];

            return (middle1 + middle2) / 2;
        }
    }
}