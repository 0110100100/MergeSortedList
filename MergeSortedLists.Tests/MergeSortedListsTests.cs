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

    [Test]
    public void TestMergeSortedLists1()
    {
        List<int> a = new List<int> { 1, 3, 5, 7 };
        List<int> b = new List<int> { 2, 4, 6, 8 };
        List<int> expected = new List<int> { 8, 7, 6, 5, 4, 3, 2, 1 };

        List<int> result = _program.MergeSortedLists(a, b);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void TestMergeSortedLists2()
    {
        List<int> a = new List<int> { 10, 20, 30 };
        List<int> b = new List<int> { 5, 15, 25, 35 };
        List<int> expected = new List<int> { 35, 30, 25, 20, 15, 10, 5 };

        List<int> result = _program.MergeSortedLists(a, b);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void TestMergeSortedLists3()
    {
        List<int> a = new List<int> { 1, 2, 3 };
        List<int> b = new List<int> { 4, 5, 6 };
        List<int> expected = new List<int> { 6, 5, 4, 3, 2, 1 };

        List<int> result = _program.MergeSortedLists(a, b);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void TestMergeSortedLists4()
    {
        List<int> a = new List<int> { 27, 30, 33 };
        List<int> b = new List<int> { 74, 82, 91 };
        List<int> expected = new List<int> { 91, 82, 74, 33, 30, 27 };

        List<int> result = _program.MergeSortedLists(a, b);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void TestMergeSortedLists5()
    {
        List<int> a = new List<int> { };
        List<int> b = new List<int> { 1, 2, 3 };
        List<int> expected = new List<int> { 3, 2, 1 };

        List<int> result = _program.MergeSortedLists(a, b);

        Assert.That(result, Is.EqualTo(expected));
    }
}