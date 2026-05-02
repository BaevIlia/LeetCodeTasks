namespace LeetCodeTasks.Tasks;

public class Task1456
{
    public int MaxVowels(string s, int k)
    {
        int vowelsCount = 0;
        int left = 0;
        int right = k;
        int res = 0;

        for (int i = 0; i < k; i++)
        {
            if (isVowel(s[i]))
                vowelsCount++;
        }

        res = vowelsCount;

        while(right < s.Length)
        {
            if (res == k)
                return res;

            if (isVowel(s[left])) vowelsCount--;
            if (isVowel(s[right])) vowelsCount++;

            left++;
            right++;

            res = Math.Max(res, vowelsCount);
        }

        return res;
    }

    public bool isVowel(char c)
    {
        return (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u');
    }
}
