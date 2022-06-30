public class Solution
{
    public bool IsPalindrome(int x)
    {
        List<char> chars = new List<char>();
        foreach (char c in x.ToString())
        {
            chars.Add(c);
        }
        chars.Reverse();
        if (string.Concat(chars).Equals(x.ToString()))
        {
            return true;
        }
        return false;
    }


    static void Main()
    {
        int x = -121;
        Solution s = new Solution();
        Console.WriteLine(s.IsPalindrome(x));
    }
}


