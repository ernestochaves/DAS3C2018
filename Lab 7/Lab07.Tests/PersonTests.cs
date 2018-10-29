using System;
using BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;

namespace Lab07.Tests
{
    [TestClass]
    public class PersonTests
    {

        [TestMethod]
        public void APersonIsCreated()
        {
            //Arrange
            PersonBL logic = new PersonBL();
            Person person = new Person()
            {
                Id = 1,
                Name = "John Smith",
                BirthDate = new DateTime(1999, 1, 1)
            };
            //Act
            logic.Create(person);
            var lastInserted = logic.GetById(1);
            //Assert
            Assert.IsNotNull(lastInserted, "The last inserted is null.");

        }

        [TestMethod]
        public void APersonMustHaveAName()
        {
            //Arrange
            PersonBL logic = new PersonBL();
            Person person = new Person()
            {
                Id = 1,
                Name = "",
                BirthDate = new DateTime(1999, 1, 1)
            };

            //Act (and assert)
            Assert.ThrowsException<ArgumentException>(() => logic.Create(person));

        }

        [TestMethod]
        public void TheAgeOfAPersonIsCalculatedCorrectly()
        {
        }

    }
}
