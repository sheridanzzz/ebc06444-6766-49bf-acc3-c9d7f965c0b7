namespace ebc06444_6766_49bf_acc3_c9d7f965c0b7.Services;
using System.Collections.Generic;
using System.Linq;

public class InputParser
{
    public List<int> ParseInput(string input)
    {
        return input.Split(' ').Select(int.Parse).ToList();
    }
}