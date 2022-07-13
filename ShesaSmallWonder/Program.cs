
Console.WriteLine(ConvertToNumber("Wello, World!"));


string ConvertToNumber(string s)
{
    //var alfa = new[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
    

    var alfa = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    var arr = s.ToUpper().ToCharArray();
    var list = new List<int>();

    for (int i = 0; i < arr.Length; i++)
    {
        if (alfa.Contains(arr[i]))
        {
            var index = alfa.IndexOf(arr[i]);
            list.Add(index + 1);
        }
    }


    return string.Join(" ", list.ToArray());
}