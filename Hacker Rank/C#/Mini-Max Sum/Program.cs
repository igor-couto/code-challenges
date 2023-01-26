
var array = args.Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

Result.miniMaxSum( (new int[] {7, 69, 2, 221, 8974}).ToList() );

class Result
{
    public static void miniMaxSum(List<int> arr)
    {
        var result = Resolve(arr);

        Console.WriteLine(result);
    }

    public static string Resolve(List<int> arr)
    {
        var orderedArr = arr.Order();

        var lowestNumber = (ulong) orderedArr.ElementAt(0);
        var higherNumber = (ulong) orderedArr.ElementAt(orderedArr.Count() -1);
        
        ulong sum = 0L;

        for(var index = 1; index < orderedArr.Count() -1; index++)
        {
            sum += (ulong) orderedArr.ElementAt(index);
        }

        return $"{sum + lowestNumber} {sum + higherNumber}";
    }
}