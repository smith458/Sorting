using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Sorting;

namespace Sorting.Test
{
    [TestFixture]
    public class SelectionSort_Test
    {
        [Test]
        public void SelectionEmptyTest()
        {
            int[] start = new int[0];
            int[] finish = new int[0];
            Assert.AreEqual(finish, Selection<int>.Sort(start));
        }

        [Test]
        public void SelectionZeroTest()
        {
            int[] start = new int[] { 0 };
            int[] finish = new int[] { 0 };
            Assert.AreEqual(finish, Selection<int>.Sort(start));
        }

        [Test]
        public void SelectionTwoNumTest()
        {
            int[] start = new int[] { 2, 1 };
            int[] finish = new int[] { 1, 2 };
            Assert.AreEqual(finish, Selection<int>.Sort(start));
        }

        [Test]
        public void SelectionBiggestLeftTest()
        {
            int[] start = new int[] { 9, 3, 5, 2, 1 };
            int[] finish = new int[] { 1, 2, 3, 5, 9 };
            Assert.AreEqual(finish, Selection<int>.Sort(start));
        }

        [Test]
        public void SelectionTenNumTest()
        {
            int[] start = new int[] { 9, 100, 13 , 0 , 43, 4, 9, 1903, 3, 55 };
            int[] finish = new int[] { 0, 3, 4, 9, 9, 13, 43, 55, 100, 1903 };
            Assert.AreEqual(finish, Selection<int>.Sort(start));
        }

        [Test]
        public void SelectionStringTest()
        {
            string[] start = new string[] { "d", "e", "f", "a", "c", "b" };
            string[] finish = new string[] {"a", "b", "c", "d", "e", "f" };
            Assert.AreEqual(finish, Selection<string>.Sort(start));
        }

        [Test]
        public void SelectionNegativeTest()
        {
            int[] start = new int[] { 10, -1, 0, 1, -3, -15 };
            int[] finish = new int[] { -15, -3, -1, 0, 1, 10 };
            Assert.AreEqual(finish, Selection<int>.Sort(start));
        }
    }
}
