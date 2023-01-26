var result = Result.TimeConversion(args[0]);

Console.WriteLine(result);

class Result
{
    public static string TimeConversion(string s)
    {
        var time = s.AsSpan();

        var AmPm = time.Slice(start: s.Length -2, length: 2);
        var hour = time.Slice(start: 0, length: 2);

        if(AmPm is "AM")
        {
            if(hour is "12")
                return $"00{CutOutHour(time)}";
            
            return CutOutAmPm(s);
        }
        else if(AmPm is "PM")
        {
            if(hour is "12") 
                return CutOutAmPm(s);
            
            var hourIn24Format = int.Parse(hour) + 12;
            return $"{hourIn24Format}{CutOutHour(time)}";
        }

        return string.Empty;
    }

    public static string CutOutAmPm(string value) => value.Substring(startIndex: 0, length: value.Length -2);

    public static ReadOnlySpan<char> CutOutHour(ReadOnlySpan<char> value) => value.Slice(2, value.Length -4);
}