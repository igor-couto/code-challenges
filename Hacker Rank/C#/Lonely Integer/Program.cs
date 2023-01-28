var array = args.Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

Result.LonelyInteger(array);

class Result
{
    public static int LonelyInteger(List<int> a)
    {
        var hashSet = new HashSet<int>();

        foreach (var item in a)
        {
            if(hashSet.Contains(item))
                hashSet.Remove(item);
            else
                hashSet.Add(item);
        }
        return hashSet.First();
    }
}