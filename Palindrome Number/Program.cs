using System.Linq;

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

    public bool IsPalindrome2(int x)
    {
        char[] arr1 = x.ToString().ToCharArray();
        char[] arr2 = (char[])arr1.Clone(); // Clone arr1 to arr2
        //char[] arr2 = new char[arr1.Length];
        //arr1.CopyTo(arr2, 0); //copy arr1 to arr2 from index 0
        Array.Reverse(arr2);
        return arr1.SequenceEqual(arr2);    // cannot use "==" 
    }

        static void Main()
    {
        int x = 121;
        Solution s = new Solution();
        Console.WriteLine(s.IsPalindrome(x));

        Console.WriteLine(s.IsPalindrome2(x));
    }
}


