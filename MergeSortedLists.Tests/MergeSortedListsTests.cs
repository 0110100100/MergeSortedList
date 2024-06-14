using System;
using System.Collections.Generic;
using NUnit.Framework;

[TestFixture]
public class MergeSortedListsTests
{
    private Program _program;

    [SetUp]
    public void Setup()
    {
        _program = new Program();
    }

    [TestCase(new int[] { 1, 3, 5, 7 }, new int[] { 2, 4, 6, 8 }, new int[] { 8, 7, 6, 5, 4, 3, 2, 1 })]
    [TestCase(new int[] { 10, 20, 30 }, new int[] { 5, 15, 25, 35 }, new int[] { 35, 30, 25, 20, 15, 10, 5 })]
    [TestCase(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 6, 5, 4, 3, 2, 1 })]
    [TestCase(new int[] { 27, 30, 33 }, new int[] { 74, 82, 91 }, new int[] { 91, 82, 74, 33, 30, 27 })]
    [TestCase(new int[] { }, new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 })]
    public void TestMergeSortedLists(int[] aArray, int[] bArray, int[] expectedArray)
    {
        List<int> a = new List<int>(aArray);
        List<int> b = new List<int>(bArray);
        List<int> expected = new List<int>(expectedArray);

        List<int> result = _program.MergeSortedLists(a, b);

        Assert.That(result, Is.EqualTo(expected));
    }
}