using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cfh.GameOfLife.Nodes;
using System;

namespace Cfh.GameOfLife_Test
{
    [TestClass]
    public class GolNodesTest
    {
        [TestMethod]
        public void GolNode_ConstructorDefault_Test()
        {
            GolNode testNode = new GolNode();
            Assert.IsFalse(testNode.IsAlive);
        }

        [TestMethod]
        public void GolNode_ConstructorFalse_Test()
        {
            GolNode testNode = new GolNode(false);
            Assert.IsFalse(testNode.IsAlive);
        }

        [TestMethod]
        public void GolNode_ConstructorTrue_Test()
        {
            GolNode testNode = new GolNode(true);
            Assert.IsTrue(testNode.IsAlive);
        }

        [TestMethod]
        public void GolNode_ShouldBeAlive_DeadNode_LessThan2LiveNeighbors_Test()
        {
            GolNode testNode = new GolNode(false);
            testNode.AddNeighbor(new GolNode(false), GolNode.NeighborLocation.Left);
            testNode.AddNeighbor(new GolNode(false), GolNode.NeighborLocation.LowerLeft);
            testNode.AddNeighbor(new GolNode(false), GolNode.NeighborLocation.LowerMiddle);
            testNode.AddNeighbor(new GolNode(false), GolNode.NeighborLocation.LowerRight);
            testNode.AddNeighbor(new GolNode(false), GolNode.NeighborLocation.Right);
            testNode.AddNeighbor(new GolNode(false), GolNode.NeighborLocation.UpperLeft);
            testNode.AddNeighbor(new GolNode(false), GolNode.NeighborLocation.UpperMiddle);
            testNode.AddNeighbor(new GolNode(false), GolNode.NeighborLocation.UpperRight);

            Assert.AreEqual(0, testNode.NumberOfLiveNeighbors());
            Assert.IsFalse(testNode.GetShouldBeAlive());
        }

        [TestMethod]
        public void GolNode_ShouldBeAlive_DeadNode_2LiveNeighbors_Test()
        {
            GolNode testNode = new GolNode(false);
            testNode.AddNeighbor(new GolNode(true), GolNode.NeighborLocation.Left);
            testNode.AddNeighbor(new GolNode(true), GolNode.NeighborLocation.LowerLeft);
            testNode.AddNeighbor(new GolNode(false), GolNode.NeighborLocation.LowerMiddle);
            testNode.AddNeighbor(new GolNode(false), GolNode.NeighborLocation.LowerRight);
            testNode.AddNeighbor(new GolNode(false), GolNode.NeighborLocation.Right);
            testNode.AddNeighbor(new GolNode(false), GolNode.NeighborLocation.UpperLeft);
            testNode.AddNeighbor(new GolNode(false), GolNode.NeighborLocation.UpperMiddle);
            testNode.AddNeighbor(new GolNode(false), GolNode.NeighborLocation.UpperRight);

            Assert.AreEqual(2, testNode.NumberOfLiveNeighbors());
            Assert.IsFalse(testNode.GetShouldBeAlive());
        }

        [TestMethod]
        public void GolNode_ShouldBeAlive_DeadNode_3LiveNeighbors_Test()
        {
            GolNode testNode = new GolNode(false);
            testNode.AddNeighbor(new GolNode(false), GolNode.NeighborLocation.Left);
            testNode.AddNeighbor(new GolNode(false), GolNode.NeighborLocation.LowerLeft);
            testNode.AddNeighbor(new GolNode(true), GolNode.NeighborLocation.LowerMiddle);
            testNode.AddNeighbor(new GolNode(true), GolNode.NeighborLocation.LowerRight);
            testNode.AddNeighbor(new GolNode(true), GolNode.NeighborLocation.Right);
            testNode.AddNeighbor(new GolNode(false), GolNode.NeighborLocation.UpperLeft);
            testNode.AddNeighbor(new GolNode(false), GolNode.NeighborLocation.UpperMiddle);
            testNode.AddNeighbor(new GolNode(false), GolNode.NeighborLocation.UpperRight);

            Assert.AreEqual(3, testNode.NumberOfLiveNeighbors());
            Assert.IsTrue(testNode.GetShouldBeAlive());
        }

        [TestMethod]
        public void GolNode_ShouldBeAlive_DeadNode_MoreThan3LiveNeighbors_Test()
        {
            GolNode testNode = new GolNode(false);
            testNode.AddNeighbor(new GolNode(false), GolNode.NeighborLocation.Left);
            testNode.AddNeighbor(new GolNode(false), GolNode.NeighborLocation.LowerLeft);
            testNode.AddNeighbor(new GolNode(false), GolNode.NeighborLocation.LowerMiddle);
            testNode.AddNeighbor(new GolNode(false), GolNode.NeighborLocation.LowerRight);
            testNode.AddNeighbor(new GolNode(true), GolNode.NeighborLocation.Right);
            testNode.AddNeighbor(new GolNode(true), GolNode.NeighborLocation.UpperLeft);
            testNode.AddNeighbor(new GolNode(true), GolNode.NeighborLocation.UpperMiddle);
            testNode.AddNeighbor(new GolNode(true), GolNode.NeighborLocation.UpperRight);

            Assert.AreEqual(4, testNode.NumberOfLiveNeighbors());
            Assert.IsFalse(testNode.GetShouldBeAlive());
        }

        [TestMethod]
        public void GolNode_ShouldBeAlive_LiveNode_LessThan2LiveNeighbors_Test()
        {
            GolNode testNode = new GolNode(true);
            testNode.AddNeighbor(new GolNode(false), GolNode.NeighborLocation.Left);
            testNode.AddNeighbor(new GolNode(false), GolNode.NeighborLocation.LowerLeft);
            testNode.AddNeighbor(new GolNode(false), GolNode.NeighborLocation.LowerMiddle);
            testNode.AddNeighbor(new GolNode(false), GolNode.NeighborLocation.LowerRight);
            testNode.AddNeighbor(new GolNode(true), GolNode.NeighborLocation.Right);
            testNode.AddNeighbor(new GolNode(false), GolNode.NeighborLocation.UpperLeft);
            testNode.AddNeighbor(new GolNode(false), GolNode.NeighborLocation.UpperMiddle);
            testNode.AddNeighbor(new GolNode(false), GolNode.NeighborLocation.UpperRight);

            Assert.AreEqual(1, testNode.NumberOfLiveNeighbors());
            Assert.IsFalse(testNode.GetShouldBeAlive());
        }

        [TestMethod]
        public void GolNode_ShouldBeAlive_LiveNode_2Or3LiveNeighbors_Test()
        {
            GolNode testNode = new GolNode(true);
            testNode.AddNeighbor(new GolNode(true), GolNode.NeighborLocation.Left);
            testNode.AddNeighbor(new GolNode(false), GolNode.NeighborLocation.LowerLeft);
            testNode.AddNeighbor(new GolNode(false), GolNode.NeighborLocation.LowerMiddle);
            testNode.AddNeighbor(new GolNode(true), GolNode.NeighborLocation.LowerRight);
            testNode.AddNeighbor(new GolNode(false), GolNode.NeighborLocation.Right);
            testNode.AddNeighbor(new GolNode(false), GolNode.NeighborLocation.UpperLeft);
            testNode.AddNeighbor(new GolNode(false), GolNode.NeighborLocation.UpperMiddle);
            testNode.AddNeighbor(new GolNode(true), GolNode.NeighborLocation.UpperRight);

            Assert.AreEqual(3, testNode.NumberOfLiveNeighbors());
            Assert.IsTrue(testNode.GetShouldBeAlive());
        }

        [TestMethod]
        public void GolNode_ShouldBeAlive_LiveNode_MoreThan3LiveNeighbors_Test()
        {
            GolNode testNode = new GolNode(false);
            testNode.AddNeighbor(new GolNode(true), GolNode.NeighborLocation.Left);
            testNode.AddNeighbor(new GolNode(true), GolNode.NeighborLocation.LowerLeft);
            testNode.AddNeighbor(new GolNode(true), GolNode.NeighborLocation.LowerMiddle);
            testNode.AddNeighbor(new GolNode(true), GolNode.NeighborLocation.LowerRight);
            testNode.AddNeighbor(new GolNode(true), GolNode.NeighborLocation.Right);
            testNode.AddNeighbor(new GolNode(true), GolNode.NeighborLocation.UpperLeft);
            testNode.AddNeighbor(new GolNode(true), GolNode.NeighborLocation.UpperMiddle);
            testNode.AddNeighbor(new GolNode(true), GolNode.NeighborLocation.UpperRight);

            Assert.AreEqual(8, testNode.NumberOfLiveNeighbors());
            Assert.IsFalse(testNode.GetShouldBeAlive());
        }

        [TestMethod]
        public void GolNodes_RowsCols_Test()
        {
            int rows = 3;
            int cols = 7;
            GolNodes testNodes = new GolNodes(rows, cols);

            Assert.AreEqual(rows, testNodes.Rows);
            Assert.AreEqual(cols, testNodes.Columns);
        }

        [TestMethod]
        public void GolNodes_InitializeNodes_Test()
        {
            int rows = 3;
            int cols = 7;
            GolNodes testNodes = new GolNodes(rows, cols);

            Assert.AreEqual(rows, testNodes.Rows);
            Assert.AreEqual(cols, testNodes.Columns);
        }

        [TestMethod]
        public void GolNodes_IsRowIndexValid_True_Test()
        {
            int rows = 3;
            int cols = 7;
            int testRowIndex = 2;
            GolNodes testNodes = new GolNodes(rows, cols);

            Assert.IsTrue(testNodes.IsRowIndexValid(testRowIndex));
        }

        [TestMethod]
        public void GolNodes_IsRowIndexValid_False_Test()
        {
            int rows = 3;
            int cols = 7;
            int testRowIndex = 3;
            GolNodes testNodes = new GolNodes(rows, cols);

            Assert.IsFalse(testNodes.IsRowIndexValid(testRowIndex));
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void GolNodes_RowIndexValid_Exception_Test()
        {
            int rows = 3;
            int cols = 7;
            int testRowIndex = 3;
            int testColIndex = 3;
            GolNodes testNodes = new GolNodes(rows, cols);
            testNodes.IsAlive(testRowIndex, testColIndex);
        }

        [TestMethod]
        public void GolNodes_IsColIndexValid_True_Test()
        {
            int rows = 3;
            int cols = 7;
            int testColIndex = 2;
            GolNodes testNodes = new GolNodes(rows, cols);

            Assert.IsTrue(testNodes.IsRowIndexValid(testColIndex));
        }

        [TestMethod]
        public void GolNodes_IsColIndexValid_False_Test()
        {
            int rows = 3;
            int cols = 7;
            int testColIndex = 7;
            GolNodes testNodes = new GolNodes(rows, cols);

            Assert.IsFalse(testNodes.IsColumnIndexValid(testColIndex));
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void GolNodes_ColIndexValid_Exception_Test()
        {
            int rows = 3;
            int cols = 7;
            int testRowIndex = 1;
            int testColIndex = 7;
            GolNodes testNodes = new GolNodes(rows, cols);
            testNodes.IsAlive(testRowIndex, testColIndex);
        }

        [TestMethod]
        public void GolNodes_IsAlive_SetIsAlive_Test()
        {
            int rows = 3;
            int cols = 7;
            int testRowIndex = 1;
            int testColIndex = 2;
            GolNodes testNodes = new GolNodes(rows, cols);
            Assert.IsFalse(testNodes.IsAlive(testRowIndex, testColIndex));

            testNodes.SetIsAlive(testRowIndex, testColIndex, true);
            Assert.IsTrue(testNodes.IsAlive(testRowIndex, testColIndex));

            testNodes.SetIsAlive(testRowIndex, testColIndex, false);
            Assert.IsFalse(testNodes.IsAlive(testRowIndex, testColIndex));
        }

        [TestMethod]
        public void GolNodes_StepNodes_Test()
        {
            int rows = 5;
            int cols = 5;
            GolNodes testNodes = new GolNodes(rows, cols);
            testNodes.SetIsAlive(2, 1, true);
            testNodes.SetIsAlive(2, 2, true);
            testNodes.SetIsAlive(2, 3, true);
            testNodes.InitializeNodes();
            testNodes.StepNodes();
            Assert.IsTrue(testNodes.IsAlive(1, 2));
            Assert.IsFalse(testNodes.IsAlive(2, 1));
            Assert.IsTrue(testNodes.IsAlive(2, 2));
            Assert.IsFalse(testNodes.IsAlive(2, 3));
            Assert.IsTrue(testNodes.IsAlive(3, 2));

            testNodes.StepNodes();
            Assert.IsFalse(testNodes.IsAlive(1, 2));
            Assert.IsTrue(testNodes.IsAlive(2, 1));
            Assert.IsTrue(testNodes.IsAlive(2, 2));
            Assert.IsTrue(testNodes.IsAlive(2, 3));
            Assert.IsFalse(testNodes.IsAlive(3, 2));

            testNodes.StepNodes();
            Assert.IsTrue(testNodes.IsAlive(1, 2));
            Assert.IsFalse(testNodes.IsAlive(2, 1));
            Assert.IsTrue(testNodes.IsAlive(2, 2));
            Assert.IsFalse(testNodes.IsAlive(2, 3));
            Assert.IsTrue(testNodes.IsAlive(3, 2));
        }
    }
}
