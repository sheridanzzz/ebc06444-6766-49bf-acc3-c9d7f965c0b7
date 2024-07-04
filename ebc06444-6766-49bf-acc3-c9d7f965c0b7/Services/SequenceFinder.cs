namespace ebc06444_6766_49bf_acc3_c9d7f965c0b7.Services;
using System.Collections.Generic;

public class SequenceFinder
{
    public static string FindLongestIncreasingSubsequence(string input)
    {
        // Parse the input string into a list of integers
        List<int> numbers = input.Split(' ').Select(int.Parse).ToList();

        // Edge case: if the input is empty
        if (numbers.Count == 0)
        {
            return string.Empty;
        }

        int n = numbers.Count;
        int[] lis = new int[n];
        int[] prev = new int[n];
        int maxLength = 0;
        int endIndex = 0;

        for (int i = 0; i < n; i++)
        {
            lis[i] = 1;
            prev[i] = -1;
            for (int j = 0; j < i; j++)
            {
                if (numbers[i] > numbers[j] && lis[i] < lis[j] + 1)
                {
                    lis[i] = lis[j] + 1;
                    prev[i] = j;
                }
            }
            if (lis[i] > maxLength)
            {
                maxLength = lis[i];
                endIndex = i;
            }
        }

        List<int> sequence = new List<int>();
        for (int i = endIndex; i >= 0; i = prev[i])
        {
            sequence.Add(numbers[i]);
            if (prev[i] == -1)
                break;
        }
        sequence.Reverse();

        // Convert the longest subsequence to a string
        return string.Join(" ", sequence);
    }
}