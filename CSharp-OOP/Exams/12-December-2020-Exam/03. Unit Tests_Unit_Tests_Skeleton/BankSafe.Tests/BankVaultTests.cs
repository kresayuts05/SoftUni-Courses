using NUnit.Framework;
using System;

namespace BankSafe.Tests
{
    public class BankVaultTests
    {
        private BankVault vault;
        private Item item;

        [SetUp] 
        public void Setup()
        {   
            vault = new BankVault();
            item = new Item("Kresa", "15");
        }

        [Test]
        public void When_CellDoesNotExist_ShouldThrowsException()
        {
            vault.AddItem("A2", item);

            Exception ex = Assert.Throws<ArgumentException>(() => vault.AddItem("K54", new Item("Pesho", "27")));

            Assert.That(ex.Message, Is.EqualTo("Cell doesn't exists!"));
        }

        [Test]
        public void When_CellIsFull_ShouldThrowsException()
        {
            vault.AddItem("A2", item);

            Exception ex = Assert.Throws<ArgumentException>(() => vault.AddItem("A2", new Item("Pesho", "27")));

            Assert.That(ex.Message, Is.EqualTo("Cell is already taken!"));
        }

        [Test]
        public void When_ItemAlreadyExist_ShouldThrowsException()
        {
            vault.AddItem("A2", item);

            Exception ex = Assert.Throws<InvalidOperationException>(() => vault.AddItem("B2", item));

            Assert.That(ex.Message, Is.EqualTo("Item is already in cell!"));
        }

        [Test]
        public void When_ItemIsAdd_ShouldSetsItsValue()
        {
            string message = vault.AddItem("A2", item);

            Assert.That(vault.VaultCells["A2"], Is.EqualTo(item));

            Assert.That(message, Is.EqualTo($"Item:{item.ItemId} saved successfully!"));
        }

        [Test]
        public void Remove_CellDoesNotExist_ShouldThrowsException()
        {
            vault.AddItem("A2", item);

            Exception ex = Assert.Throws<ArgumentException>(() => vault.RemoveItem("KSh", item));

            Assert.That(ex.Message, Is.EqualTo("Cell doesn't exists!"));
        }

        [Test]
        public void Remove_ItemInCellDoesNotExist_ShouldThrowsException()
        {
            vault.AddItem("A2", item);

            Exception ex = Assert.Throws<ArgumentException>(() => vault.RemoveItem("A2", new Item("5", "45448")));

            Assert.That(ex.Message, Is.EqualTo("Item in that cell doesn't exists!"));
        }

        [Test]
        public void When_ItemIsRemoved_ShouldSetsItsValueToNull()
        {
            vault.AddItem("A2", item);

            string message = vault.RemoveItem("A2", item);

            Assert.That(vault.VaultCells["A2"], Is.EqualTo(null));

            Assert.That(message, Is.EqualTo($"Remove item:{item.ItemId} successfully!"));
        }
    }
}