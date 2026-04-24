namespace LeetCodeTasks.Tasks;

public class Task392
{
    public bool IsSubsequence(string s, string t)
    {
        int p1 = 0;
        int p2 = 0;

        List<char> result = new();

        while (p1 < s.Length && p2 < t.Length)
        {
            if (s[p1] == t[p2])
            {
                result.Add(s[p1]);
                p1++;
                p2++;
            }
            else
                p2++;
        };

        return result.Count() == s.Length;
    }
}