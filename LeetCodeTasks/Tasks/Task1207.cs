namespace LeetCodeTasks.Tasks;

public class Task1207
{
    public bool UniqueOccurrences(int[] arr)
    {
        Dictionary<int, int> occurences = new();

        foreach (var i in arr)
        {
            if (occurences.ContainsKey(i))
                occurences[i]++;
            else
                occurences.Add(i, 1);
        }
        var x = occurences.ToHashSet();

        return occurences.Values.Distinct().Count() < occurences.Count ? false : true;
    }
}