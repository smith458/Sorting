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
    public class BubbleSort_Test
    {
        [Test]
        public void BubbleEmptyTest()
        {
            int[] start = new int[0];
            int[] finish = new int[0];
            Assert.AreEqual(finish, Bubble<int>.Sort(start));
        }

        [Test]
        public void BubbleZeroTest()
        {
            int[] start = new int[] { 0 };
            int[] finish = new int[] { 0 };
            Assert.AreEqual(finish, Insert<int>.Sort(start));
        }

        [Test]
        public void BubbleTwoNumTest()
        {
            int[] start = new int[] { 2, 1 };
            int[] finish = new int[] { 1, 2 };
            Assert.AreEqual(finish, Insert<int>.Sort(start));
        }

        [Test]
        public void BubbleBiggestLeftTest()
        {
            int[] start = new int[] { 9, 3, 5, 2, 1 };
            int[] finish = new int[] { 1, 2, 3, 5, 9 };
            Assert.AreEqual(finish, Insert<int>.Sort(start));
        }

        [Test]
        public void BubbleTenNumTest()
        {
            int[] start = new int[] { 9, 100, 13 , 0 , 43, 4, 9, 1903, 3, 55 };
            int[] finish = new int[] { 0, 3, 4, 9, 9, 13, 43, 55, 100, 1903 };
            Assert.AreEqual(finish, Insert<int>.Sort(start));
        }

        [Test]
        public void BubbleStringTest()
        {
            string[] start = new string[] { "d", "e", "f", "a", "c", "b" };
            string[] finish = new string[] {"a", "b", "c", "d", "e", "f" };
            Assert.AreEqual(finish, Insert<string>.Sort(start));
        }

        [Test]
        public void BubbleNegativeTest()
        {
            int[] start = new int[] { 10, -1, 0, 1, -3, -15 };
            int[] finish = new int[] { -15, -3, -1, 0, 1, 10 };
            Assert.AreEqual(finish, Insert<int>.Sort(start));
        }
    }
}
