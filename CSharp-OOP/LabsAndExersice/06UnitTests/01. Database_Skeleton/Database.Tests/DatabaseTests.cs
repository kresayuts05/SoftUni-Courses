using NUnit.Framework;
using System;
using System.Linq;

namespace Tests
{
    public class DatabaseTests
    {
        private Database.Database database;

        [SetUp]
        public void Setup()
        {
            database = new Database.Database();
        }

        [Test]
        public void Add_ShouldThrowsExeption_WhenCapasityIsExceeded()
        {
            for (int i = 0; i < 16; i++)
            {
                database.Add(i);
            }

            Assert.Throws<InvalidOperationException>(() => database.Add(27));
        }

        [Test]
        public void Add_ShouldIncreaseItsCount_WhenInsertNewElement()
        {
            int n = 7;

            for (int i = 0; i < 7; i++)
            {
                database.Add(i);
            }

            Assert.That(database.Count, Is.EqualTo(n));
        }

        [Test]
        public void Add_ShouldAddNewElementToDatabase()
        {
            int num = 27;
            database.Add(num);

            int[] arr = database.Fetch();

            Assert.IsTrue(arr.Contains(num));
        }

        [Test]
        public void Remove_ShouldThrowExeption_WhenItIsEmpty()
        {
            Assert.Throws<InvalidOperationException>(() => database.Remove());
        }

        [Test]
        public void Remove_ShouldDecreaseItsValue()
        {
            database.Add(1);
            database.Add(2);
            database.Add(3);

            int[] arr = database.Fetch();
            database.Remove();

            Assert.That(database.Count, Is.Not.EqualTo(arr.Length));
        }

        [Test]
        public void Remove_ShouldRemoveElementFromDatabase()
        {
            int lastElement = 27;

            database.Add(1);
            database.Add(2);
            database.Add(lastElement);

            database.Remove();
            int[] arr = database.Fetch();

            Assert.IsFalse(arr.Contains(lastElement));
        }

        [Test]
        public void Fetch_ShoudReturnCopiedArray()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            database = new Database.Database(arr);

            int[] firstCopy = database.Fetch();

            database.Add(1);
            int[] secondCopy = database.Fetch();

            Assert.That(firstCopy, Is.Not.EqualTo(secondCopy));
        }

        [Test]
        public void Add_ShouldThrowsExeption_WhenAddMoreElements()
        {
            
            Assert.Throws<InvalidOperationException>(() =>
                     database = new Database.Database(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18));
        }

        [Test]
        public void Add_ShouldAddElement()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            database = new Database.Database(arr);

            Assert.That(arr.Length, Is.EqualTo(database.Count));

            int[] elements = database.Fetch();
            Assert.That(elements, Is.EquivalentTo(arr));
        }
    }
}