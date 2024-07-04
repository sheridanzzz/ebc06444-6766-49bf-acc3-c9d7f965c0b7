using System;
using ebc06444_6766_49bf_acc3_c9d7f965c0b7.Services;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a sequence of integers separated by spaces:");
        string input = Console.ReadLine();
        
        var longestSubsequence = SequenceFinder.FindLongestIncreasingSubsequence(input);

        Console.WriteLine("Longest Increasing Subsequence:");
        Console.WriteLine(longestSubsequence);
    }
}