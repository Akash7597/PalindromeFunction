using System;
using System.Text;
(bool, int) Palindrome(string str)
{
    string tstr;
    tstr = tstr.ToUpper();
    var sb = new StringBuilder();
    foreach (char c in tstr)
    {
        if (!char.IsPunctuation(c) && !char.IsWhiteSpace(c))
        {
            sb.Append(c);
        }
    }
    tstr = sb.ToString();
    int i = 0, j = tstr.Length - 1;
    while (i <= j)
    {
        if (tstr[i] != tstr[j])
        {
            return (false, 0);
        }
        i++;
        j--;
    }
    return (true, tstr.Length);
}

string inputstr = "";
(bool b, int l) r;
while (inputstr != "exit")
{
    inputstr = Console.ReadLine();
    if (inputstr != "exit")
    {
        r = Palindrome(inputstr);
        Console.WriteLine($"Palindrome: {r.b}, Length: {r.l}");
    }
}