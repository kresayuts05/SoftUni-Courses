using ExtendedDatabase;
using NUnit.Framework;
using System;

namespace Tests
{
    public class ExtendedDatabaseTests
    {
        private ExtendedDatabase.ExtendedDatabase database;

        [SetUp]
        public void Setup()
        {
            database = new ExtendedDatabase.ExtendedDatabase();
        }

        [Test]
        public void Add_WhenDatabaseCapacityIsExceed_ShouldThrowExeption()
        {
            int n = 16;

            for (int i = 0; i < n; i++)
            {
                Person person = new Person(i, $"Username: {i}");
                database.Add(person);
            }

            Assert.Throws<InvalidOperationException>(() => database.Add(new Person(16, "16")));
        }

        [Test]
        public void Add_ShouldThrowExeption_WhenUsernameIsUsed()
        {
            string username = "Kresa";
            database.Add(new Person(5, username));

            Assert.Throws<InvalidOperationException>(() => database.Add(new Person(16, username)));
        }

        [Test]
        public void Add_ShouldThrowExeption_WhenIdIsUsed()
        {
            database.Add(new Person(5, "Kresa"));

            Assert.Throws<InvalidOperationException>(() => database.Add(new Person(5, "Lucho")));
        }

        [Test]
        public void Add_ShouldIncreaseCounter_WhenValidPersonIsAdd()
        {
            int n = 4;

            for (int i = 0; i < n; i++)
            {
                database.Add(new Person(i, $"Username: {i}"));
            }

            Assert.That(n, Is.EqualTo(database.Count));
        }

        [Test]
        public void Remove_ShouldThrowsException_WhenDatabaseIsEmpty()
        {
            Assert.Throws<InvalidOperationException>(() => database.Remove());
        }

        [Test]
        public void Remove_ShouldDecreaseCounter_WhenValidPersonIsRemoved()
        {
            int n = 4;

            for (int i = 0; i < n; i++)
            {
                database.Add(new Person(i, $"Username: {i}"));
            }

            database.Remove();
            Assert.That(n - 1, Is.EqualTo(database.Count));
        }

        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void FindByUsername_ShouldThrowsException_WhenDatabaseIsEmpty(string username)
        {
            Assert.Throws<ArgumentNullException>(() => database.FindByUsername(username));
        }

        [Test]
        public void FindByUsername_ShouldThrowsException_WhenUsernameIsNotFound()
        {
            Assert.Throws<InvalidOperationException>(() => database.FindByUsername("Gogi"));
        }

        [Test]
        public void FindByUsername_ShouldReturnPerson_WhenUsernameISFound()
        {
            Person person = new Person(15, "Kresa");
            database.Add(person);

            Assert.That(person, Is.EqualTo(database.FindByUsername("Kresa")));
        }

        [Test]
        [TestCase(-23)]
        public void FindById_ShouldThrowsException_WhenUsernameIdIsNotPositive(long id)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => database.FindById(id));
        }

        [Test]
        public void FindById_ShouldThrowsException_WhenUsernameIdIsNotFound()
        {
            Assert.Throws<InvalidOperationException>(() => database.FindById(100));
        }

        [Test]
        public void FindById_ShouldReturnPerson_WhenIdISFound()
        {
            Person person = new Person(15, "Kresa");
            database.Add(person);

            Assert.That(person, Is.EqualTo(database.FindById(15)));
        }

        [Test]
        public void Ctor_ShouldAddPeople()
        {
            Person[] people = new Person[5];
            for (int i = 0; i < 5; i++)
            {
                people[i] = new Person(i, $"Username: {i}");
            }

            database = new ExtendedDatabase.ExtendedDatabase(people);

            Assert.That(database.Count, Is.EqualTo(people.Length));
        }

        [Test]
        public void Ctor_ShouldThrowsException_WhenCapasityIsExedeed()
        {
            Person[] people = new Person[18];
            for (int i = 0; i < 18; i++)
            {
                people[i] = new Person(i, $"Username: {i}");
            }

            Assert.Throws<ArgumentException>(() => database = new ExtendedDatabase.ExtendedDatabase(people));
        }
    }
}