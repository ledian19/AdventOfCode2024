namespace AdventOfCode2024;

public class Day1{
    public static int GetSum(List<int> list1, List<int> list2) {
        list1.Sort();
        list2.Sort();

        return list1.Select((t, i) => Math.Abs(t - list2[i])).Sum();
    }
}