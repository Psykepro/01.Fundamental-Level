namespace CustomLinkedListTests
{
    using System;

    using CustomLinkedList;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class DynamicListTests
    {
        [TestMethod]
        public void TestCreateEmptyDynamicList_ShouldHaveCountZero()
        {
            // Arrange
            DynamicList<string> dynamicList = new DynamicList<string>();
            int expectedCount = 0;

            // Act
            // Nothing for this test

            // Assert
            Assert.AreEqual(expectedCount, dynamicList.Count, "A newly created list should have 0 count.");
        }

        [TestMethod]
        public void TestAddElementToEmptyDynamicList_ShouldAddItem()
        {
            // Arrange
            DynamicList<string> dynamicList = new DynamicList<string>();
            int expectedCount = 1;

            // Act
            string testString = "testString";
            dynamicList.Add(testString);

            // Assert
            Assert.AreEqual(testString,dynamicList[0],"The value of index 0 should be equal to the first added value.");
            Assert.AreEqual(expectedCount, dynamicList.Count, "When add 1 item should have count -> 1.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "When add null element should throw ArgumentNullException.")]
        public void TestAddNullElementToDynamicList_ShouldThrowArgumentNullException()
        {
            // Arrange
            DynamicList<string> dynamicList = new DynamicList<string>();

            // Act
            dynamicList.Add(null);

            // Assert
            // Nothing for this test
        }

        [TestMethod]
        public void TestAddManyElementsToEmptyDynamicList_ShouldAddAllItems()
        {
            // Arrange
            DynamicList<string> dynamicList = new DynamicList<string>();
            int expectedCount = 2;

            // Act
            string testString = "testString";
            string testString2 = "testString2";
            dynamicList.Add(testString);
            dynamicList.Add(testString2);

            // Assert
            Assert.AreEqual(testString, dynamicList[0], "The value of index 0 should be equal to the first added value.");
            Assert.AreEqual(testString2, dynamicList[1], "The value of index 1 should be equal to the second added value.");
            Assert.AreEqual(expectedCount, dynamicList.Count, "When add 2 items should have count -> 2.");
        }

        [TestMethod]       
        public void TestRemoveAtFromDynamicList_ShouldRemoveItemAtTheGiveIndex()
        {
            // Arrange
            DynamicList<string> dynamicList = new DynamicList<string>();
            string testString = "testString";
            int expectedCount = 0;
            dynamicList.Add(testString);

            // Act
            dynamicList.RemoveAt(0);

            // Assert            
            Assert.AreEqual(expectedCount, dynamicList.Count, "The item wasn't removed, should remove the item at the given index.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Should throw ArgumentOutOfRangeException when try to remove item from empty list.")]
        public void TestRemoveAtFromEmptyDynamicList_ShouldThrowArgumentOutOfRangeException()
        {
            // Arrange
            DynamicList<string> dynamicList = new DynamicList<string>();

            // Act
            dynamicList.RemoveAt(0);

            // Assert            
            // Nothing for this test
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Should throw ArgumentOutOfRangeException when try to remove item at negative index.")]
        public void TestRemoveAtNegativeIndexFromDynamicList_ShouldThrowArgumentOutOfRangeException()
        {
            // Arrange
            DynamicList<string> dynamicList = new DynamicList<string>();
            string testString = "testString";
            dynamicList.Add(testString);

            // Act
            dynamicList.RemoveAt(-1);

            // Assert            
            // Nothing for this test
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Should throw ArgumentOutOfRangeException when try to remove item at index bigger than the list's count.")]
        public void TestRemoveAtIndexBiggerThanDynamicListCount_ShouldThrowArgumentOutOfRangeException()
        {
            // Arrange
            DynamicList<string> dynamicList = new DynamicList<string>();
            string testString = "testString";
            dynamicList.Add(testString);

            // Act
            dynamicList.RemoveAt(2);

            // Assert            
            // Nothing for this test
        }

        [TestMethod]        
        public void TestRemoveItemFromDynamicList_ShouldRemoveTheItem()
        {
            // Arrange
            DynamicList<string> dynamicList = new DynamicList<string>();
            int expectedCount = 0;
            string testString = "testString";
            dynamicList.Add(testString);

            // Act
            dynamicList.Remove(testString);

            // Assert            
            Assert.AreEqual(expectedCount,dynamicList.Count,"The item should be removed.");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "Should throw InvalidOperationException when try to remove null item from the list.")]
        public void TestRemoveNullItemFromDynamicList_ShouldThrowInvalidOperationException()
        {
            // Arrange
            DynamicList<string> dynamicList = new DynamicList<string>();
            string testString = "testString";
            dynamicList.Add(testString);

            // Act
            dynamicList.Remove(null);

            // Assert            
            // Nothing for this test
        }

        [TestMethod]
        public void TestIndexOfItemFromDynamicList_ShouldReturnTheCorrectIndex()
        {
            // Arrange
            DynamicList<string> dynamicList = new DynamicList<string>();
            string testString = "testString";
            string testString2 = "testString2";
            int expectedIndex = 1;
            dynamicList.Add(testString);
            dynamicList.Add(testString2);

            // Act
            int returnedIndex = dynamicList.IndexOf(testString2);

            // Assert            
            Assert.AreEqual(expectedIndex,returnedIndex,"Should return the index of the given item.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),"When try to get index of non-existing item, should throw ArgumentException.")]
        public void TestIndexOfNonExistingItemInDynamicList_ShouldThrowException()
        {
            // Arrange
            DynamicList<string> dynamicList = new DynamicList<string>();
            string testString = "testString";
            string testString2 = "testString2";
            string testString3 = "testString3";
            dynamicList.Add(testString);
            dynamicList.Add(testString2);

            // Act
            int returnedIndex = dynamicList.IndexOf(testString3);

            // Assert            
            // Nothing for this test
        }

        [TestMethod]
        public void TestContainsItemInDynamicList_ShouldReturnTheCorrectBool()
        {
            // Arrange
            DynamicList<string> dynamicList = new DynamicList<string>();
            string testString = "testString";
            bool expectedBool = true;

            dynamicList.Add(testString);

            // Act
            bool returnedBool = dynamicList.Contains(testString);

            // Assert            
            Assert.AreEqual(expectedBool, returnedBool, "The returned value isn't correct, should return true.");
        }

        [TestMethod]
        public void TestContainsNonExistingItemInDynamicList_ShouldReturnTheCorrectBool()
        {
            // Arrange
            DynamicList<string> dynamicList = new DynamicList<string>();
            string testString = "testString";
            bool expectedBool = false;

            dynamicList.Add(testString);

            // Act
            bool returnedBool = dynamicList.Contains("shit");

            // Assert            
            Assert.AreEqual(expectedBool, returnedBool, "The returned value isn't correct, should return false.");
        }

        [TestMethod]
        public void TestReturnValueAtExistingIndexInDynamicList_ShouldReturnTheValue()
        {
            // Arrange
            DynamicList<string> dynamicList = new DynamicList<string>();
            string testString = "testString";
            string expectedValue = testString;

            dynamicList.Add(testString);

            // Act
            string returnedValue = dynamicList[0];

            // Assert            
            Assert.AreEqual(expectedValue, returnedValue, "The value isn't correct, should return the correct value.");
        }

        [TestMethod]        
        public void TestChangeValueAtExistingIndexInDynamicList_ShouldChangeTheValue()
        {
            // Arrange
            DynamicList<string> dynamicList = new DynamicList<string>();
            string testString = "testString";
            string expectedValue = "shit";

            dynamicList.Add(testString);

            // Act
            dynamicList[0] = "shit";
            string returnedValue = dynamicList[0];

            // Assert            
            Assert.AreEqual(expectedValue,returnedValue,"The value isn't changed, should change the value.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),"When u try to set value to non-existing index in the list, should throw ArgumentOutOfRangeException.")]
        public void TestSetValueToNonExistingIndexInDynamicList_ShouldThrowArgumentOutOfRangeException()
        {
            // Arrange
            DynamicList<string> dynamicList = new DynamicList<string>();

            // Act
            dynamicList[1] = "shit";

            // Assert            
            // Nothing for this test
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "When u try to get value from non-existing index in the list, should throw ArgumentOutOfRangeException.")]
        public void TestGetValueFromNonExistingIndexInDynamicList_ShouldThrowArgumentOutOfRangeException()
        {
            // Arrange
            DynamicList<string> dynamicList = new DynamicList<string>();

            // Act
            string testString = dynamicList[1];

            // Assert            
            // Nothing for this test
        }
    }
}
