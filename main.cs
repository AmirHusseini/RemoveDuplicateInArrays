using System;
using System.Linq; //needed to use Concat and Distinct

public class MergeNames
{
    public static string[] UniqueNames(string[] names1, string[] names2)
    {
        string[] merging= names1.Concat(names2).ToArray();// adds both names1/2 to array merging.
        string[] uniqe = merging.Distinct().ToArray(); //Distinct removes duplicates from merging array.
        return uniqe;
    }
    
    public static void Main(string[] args)
    {
        string[] names1 = new string[] {"Ava", "Emma", "Olivia"};
        string[] names2 = new string[] {"Olivia", "Sophia", "Emma"};
        Console.WriteLine(string.Join(", ", MergeNames.UniqueNames(names1, names2))); // should print Ava, Emma, Olivia, Sophia
    }
}