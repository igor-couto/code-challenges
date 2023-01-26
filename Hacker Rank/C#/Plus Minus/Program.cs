using System.Globalization;

var array = args.Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

Result.PlusMinus(array);

class Result
{
    public static void PlusMinus(List<int> array)
    {
        (var positiveRatio, var negativeRatio, var zeroRatio) = GetRatios(array);

        Console.WriteLine(positiveRatio);
        Console.WriteLine(negativeRatio);
        Console.WriteLine(zeroRatio);
    }

    public static (string, string, string) GetRatios(List<int> array)
    {
        var numberOfValues = (float) array.Count;

        var positiveValues = 0;
        var negativeValues = 0;
        var zeroValues = 0;

        foreach (var value in array)
        {
            if(value > 0)
            {
                positiveValues++;
                continue;
            }

            if(value < 0)
            {
                negativeValues++;
                continue;
            }

            if(value == 0)
            {
                zeroValues++;
                continue;
            }
        }

        var positiveRatio = positiveValues/numberOfValues;
        var negativeRatio = negativeValues/numberOfValues;
        var zeroRatio = zeroValues/numberOfValues;

        return (
            positiveRatio.ToString("0.000000", CultureInfo.InvariantCulture),
            negativeRatio.ToString("0.000000", CultureInfo.InvariantCulture),
            zeroRatio.ToString("0.000000", CultureInfo.InvariantCulture)
        );
    }
}