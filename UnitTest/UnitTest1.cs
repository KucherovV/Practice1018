using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Laba3;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        ArrayProcessing ar;

        [TestMethod]
        public void TestSortArrayMethod1()
        {
            ar = new ArrayProcessing();

            int[] expected = { 12, 31, 45, 65 };
            int[] actual = { 31, 65, 12, 45 };
            ar.arr = actual;
            actual = ar.array_sort();
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestTask9Method()
        {
            ar = new ArrayProcessing();
            int[] array = { 12, 56, 23, 12, 57 };
            int[] expected = { 68, 2 };
            ar.arr = array;
            int[] actual = ar.task9(10);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestTask15Method()
        {
            ar = new ArrayProcessing();

            int[] array = { 34, 123, 776, 23 };
            int[] expcted = { 157, 2 };
            ar.arr = array;
            int[] actual = ar.task15();
            CollectionAssert.AreEqual(expcted, actual);
        }

        [TestMethod]
        public void TestMDMethod()
        {
            ar = new ArrayProcessing();

            int[] array = { 15, 25, 32 };
            double[] expected = { 24, 73 };
            ar.arr = array;
            double[] actual = ar.MO_Disp();
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
