namespace AdventOfCode2024;

public class Day1{
    public static int GetSumPart1(List<int> list1, List<int> list2) {
        list1.Sort();
        list2.Sort();

        return list1.Select((t, i) => Math.Abs(t - list2[i])).Sum();
    }
    
    public static int FindSimilaritiesPart2(List<int> list1, List<int> list2) {
        return list1.Sum(l1 => list2.Count(l2 => l2 == l1) * l1);
    }
}