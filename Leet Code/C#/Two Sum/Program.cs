using TwoSum;

var intArray = args[0]
    .Split(',')
    .Select(int.Parse)
    .ToArray();

Solution.TwoSum(intArray, int.Parse(args[0]));