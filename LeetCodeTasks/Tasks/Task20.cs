namespace LeetCodeTasks.Tasks;

public class Task20
{
    public bool IsValid(string s)
    {
        Dictionary<char, char> brackets = new()
        {
            { ')', '(' },
            { ']', '[' },
            { '}', '{' }
        };
  
        
        Stack<char> stack = new Stack<char>();
        foreach (var c in s.ToCharArray())
        {
            if (brackets.ContainsValue(c))
            {
                stack.Push(c);
            }
            else if (brackets.ContainsKey(c))
            {
                if (stack.Count == 0 || stack.Pop() != brackets[c])
                {
                    return false;
                }
            }
        }

        if (stack.Count == 0)
        {
            return true;
        }


        return false;

    }
}