namespace ebc06444_6766_49bf_acc3_c9d7f965c0b7.Tests;
using Services;
using NUnit.Framework;
using NUnit.Framework.Legacy;


[TestFixture]
public class SequenceFinderTests
{
    private SequenceFinder _sequenceFinder;

    [SetUp]
    public void Setup()
    {
        _sequenceFinder = new SequenceFinder();
    }

    [Test]
    public void TestCase1()
    {
        var input = "6 1 5 9 2";
        var expected = "1 5 9";
        var result = SequenceFinder.FindLongestIncreasingSubsequence(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void TestCase2()
    {
        var input = "923 11613 30483 19569 24201 13461 1189 30793 8848 16914 16053 21700 22116 3852 20909 5231 31469 3862 16353 22813 28735 4421 3618 32303 9932 31892 7823 22547 28888 11143 11695 3339 2094 11023 9661 27440 7186 24750 15427 24502 31606 23515 3563 29553 12145 22184 11409 28824 6636 10658 21404 5578 27807 14073 13967 31310 3132 4321 7643 1951 13289 24375 17912 11304";
        var expected = "3862 16353 22813 28735";
        var result = SequenceFinder.FindLongestIncreasingSubsequence(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    // Add more test cases as needed
}