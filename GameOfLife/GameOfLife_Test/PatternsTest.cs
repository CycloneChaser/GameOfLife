using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cfh.GameOfLife.Patterns;
using System;

namespace Cfh.GameOfLife_Test
{
    [TestClass]
    public class PatternsTest
    {
        [TestMethod]
        public void Pattern_RowsAndColumns_Test()
        {
            int rows = 3;
            int cols = 7;
            Pattern testPattern = new Pattern(rows, cols);
            Assert.AreEqual(rows, testPattern.Rows);
            Assert.AreEqual(cols, testPattern.Columns);
        }

        [TestMethod]
        public void Pattern_SetIsAlive_Test()
        {
            int rows = 3;
            int cols = 7;
            int testAliveRow = 1;
            int testAliveCol = 2;
            int testDeadRow = 2;
            int testDeadCol = 1;
            Pattern testPattern = new Pattern(rows, cols);
            testPattern.SetIsAlive(testAliveRow, testAliveCol, true);
            Assert.IsTrue(testPattern.IsAlive(testAliveRow, testAliveCol));
            Assert.IsFalse(testPattern.IsAlive(testDeadRow, testDeadCol));
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Pattern_SetIsAlive_RowIndexValid_Exception_Test()
        {
            int rows = 3;
            int cols = 7;
            int testRow = 3;
            int testCol = 2;
            Pattern testPattern = new Pattern(rows, cols);
            testPattern.SetIsAlive(testRow, testCol, true);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Pattern_SetIsAlive_ColIndexValid_Exception_Test()
        {
            int rows = 3;
            int cols = 7;
            int testRow = 1;
            int testCol = 7;
            Pattern testPattern = new Pattern(rows, cols);
            testPattern.SetIsAlive(testRow, testCol, true);
        }

        [TestMethod]
        public void Pattern_StepPattern_Test()
        {
            int rows = 3;
            int cols = 7;
            Pattern testPattern = new Pattern(rows, cols);
            Assert.AreEqual(rows, testPattern.Rows);
            Assert.AreEqual(cols, testPattern.Columns);
        }
    }
}

