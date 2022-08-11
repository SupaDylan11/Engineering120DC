using NUnit.Framework;
using Moq;
using NorthwindBusiness;
using NorthwindData;
using NorthwindData.Services;
using System.Data;
using System.Collections.Generic;
using System;

namespace NorthwindTests
{
    public class CustomerManagerShould
    {
        private CustomerManager _sut;
        // fakes - in every database (not covered this lesson

        #region moq dummies
        [Ignore("Ment to fail")]
        [Test]
        public void BeAbleToBeConstructed()
        {
            //act
            _sut = new CustomerManager(null);
            Assert.That(_sut, Is.InstanceOf<CustomerManager>());
        }

        [Test]
        public void BeAbleToBeConstructedWithMoq()
        {
            //use moq to create a dummy object which implements ICustomerService
            //arrange
            var mockCustomerService = new Mock<ICustomerService>();
            //act - retrieve the ICustomerService object associated
            //mock object doesn't do anything yet.
            _sut = new CustomerManager(mockCustomerService.Object);
            Assert.That(_sut, Is.InstanceOf<CustomerManager>());
        }
        #endregion

        #region stubs
        [Test]
        public void ReturnTrueWhenUpdateIsCalledWithValidID()
        {
            //arrange
            var mockCustomerService = new Mock<ICustomerService>();
            //act - retrieve the ICustomerService object associated
            //mock object doesn't do anything yet.

            var customer = new Customer
            {
                CustomerId = "MANDA"
            };

            //set up service so it returns what i want
            mockCustomerService.Setup(cs => cs.GetCustomerById("MANDA")).Returns(customer);

            //act
            _sut = new CustomerManager(mockCustomerService.Object);
            var result = _sut.Update("MANDA", It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>());
        }
        #endregion

        public void NotChangeTheSelectedCustomer_WhenUpdateIsCalled_WithInvalidId()
        {
            // Arrange
            var mockCustomerService = new Mock<ICustomerService>();
            var customer = new Customer
            {
                CustomerId = "MANDA",
                ContactName = "Nish Mandal",
                CompanyName = "Sparta Global",
                City = "Birmingham"
            };

            // Set up the service so that it returns what I want
            mockCustomerService.Setup(cs => cs.GetCustomerById("MANDA")).Returns((Customer)null);

            // Act
            _sut = new CustomerManager(mockCustomerService.Object);
            _sut.SelectedCustomer = customer;
            var result = _sut.Update("MANDA", "Nishant Mandal", "UK", "London", null);

            // Assert
            Assert.That(!result);
            Assert.That(_sut.SelectedCustomer.ContactName, Is.EqualTo("Nish Mandal"));
            Assert.That(_sut.SelectedCustomer.CompanyName, Is.EqualTo("Sparta Global"));
            Assert.That(_sut.SelectedCustomer.Country, Is.Null);
            Assert.That(_sut.SelectedCustomer.City, Is.EqualTo("Birmingham"));
        }

        #region delete tests
        [Test]
        public void ReturnTrueWhenDeleteIsCalledWithAValidID()
        {
            //arrange
            var mockCustomerService = new Mock<ICustomerService>();
            //act - retrieve the ICustomerService object associated
            //mock object doesn't do anything yet.

            var customer = new Customer
            {
                CustomerId = "MANDA"
            };

            //set up service so it returns what i want
            mockCustomerService.Setup(cs => cs.GetCustomerById("MANDA")).Returns(customer);

            //act
            _sut = new CustomerManager(mockCustomerService.Object);
            var result = _sut.Delete("MANDA");
            Assert.That(result);
        }

        [Test]
        public void SetSelectedCustomerToNullWhenDeleteIsCallWithAValidID()
        {
            // Arrange
            var mockCustomerService = new Mock<ICustomerService>();
            var customer = new Customer
            {
                CustomerId = "MANDA",
                ContactName = "Nish Mandal",
                CompanyName = "Sparta Global",
                City = "Birmingham"
            };

            // Set up the service so that it returns what I want
            mockCustomerService.Setup(cs => cs.GetCustomerById("MANDA")).Returns(customer);

            // Act
            _sut = new CustomerManager(mockCustomerService.Object);
            //_sut.SelectedCustomer = customer;
            var result = _sut.Delete("MANDA");

            // Assert
            Assert.That(_sut.SelectedCustomer, Is.Null);
        }

        [Test]
        public void ReturnFalseWhenDeleteIsCalledWithAnInvalidID()
        {
            //arrange
            var mockCustomerService = new Mock<ICustomerService>();
            //act - retrieve the ICustomerService object associated
            //mock object doesn't do anything yet.

            var customer = new Customer
            {
                CustomerId = "MANDA"
            };

            //set up service so it returns what i want
            mockCustomerService.Setup(cs => cs.GetCustomerById("MANDA")).Returns(customer);

            //act
            _sut = new CustomerManager(mockCustomerService.Object);
            var result = _sut.Delete("MANDAL");
            Assert.That(!result);
        }

        [Test]
        public void NotChangeTheSelectedCustomerWhenDeleteIsCalledWithAnInvalidID()
        {
            var mockCustomerService = new Mock<ICustomerService>();
            var customer = new Customer
            {
                CustomerId = "MANDA",
                ContactName = "Nish Mandal",
                CompanyName = "Sparta Global",
                City = "Birmingham"
            };

            // Set up the service so that it returns what I want
            mockCustomerService.Setup(cs => cs.GetCustomerById("MANDA")).Returns((Customer)null);

            // Act
            _sut = new CustomerManager(mockCustomerService.Object);
            _sut.SelectedCustomer = customer;
            var result = _sut.Delete("MANDA");

            // Assert
            Assert.That(!result);
            Assert.That(_sut.SelectedCustomer.ContactName, Is.EqualTo("Nish Mandal"));
            Assert.That(_sut.SelectedCustomer.CompanyName, Is.EqualTo("Sparta Global"));
            Assert.That(_sut.SelectedCustomer.Country, Is.Null);
            Assert.That(_sut.SelectedCustomer.City, Is.EqualTo("Birmingham"));
        }

        #endregion

        #region homework
        [Test]
        public void GivenAnEmptyDatabaseReturnsEmptyList()
        {
            var mockCustomerService = new Mock<ICustomerService>();
            _sut = new CustomerManager(mockCustomerService.Object);
            mockCustomerService.Setup(cs => cs.GetCustomerList()).Returns(new List<Customer>());
            Assert.That(_sut.RetrieveAll(), Is.EqualTo(new List<Customer>()));
        }

        [Test]
        public void RetrieveAllWithCustomerWillReturnAListWithCustomer()
        {
            var mockCustomerService = new Mock<ICustomerService>();
            var customer = new Customer
            {
                CustomerId = "MANDA",
                ContactName = "Nish Mandal",
                CompanyName = "Sparta Global",
                City = "Birmingham"
            };

            // Set up the service so that it returns what I want
            mockCustomerService.Setup(cs => cs.GetCustomerList()).Returns(new List<Customer>() { customer });

            // Act
            _sut = new CustomerManager(mockCustomerService.Object);
            Assert.That(_sut.RetrieveAll(), Is.EqualTo(new List<Customer>() { customer }));
        }

        [Test]
        public void WithASingleCustomer_SetSelectedCustomer_ReturnExpectedCustomerData()
        {
            var mockCustomerService = new Mock<ICustomerService>();
            var customer1 = new Customer
            {
                CustomerId = "YE",
                ContactName = "Kanye West",
                CompanyName = "Kanye West Church",
                City = "Murica"
            };

            mockCustomerService.Setup(cs => cs.GetCustomerById(customer1.CustomerId)).Returns(customer1);

            _sut = new CustomerManager(mockCustomerService.Object);
            _sut.SetSelectedCustomer(customer1);
            Assert.That(_sut.SelectedCustomer.ContactName, Is.EqualTo("Kanye West"));
            Assert.That(_sut.SelectedCustomer.City, Is.EqualTo("Murica"));
        }

        [Test]
        public void WithTheDBOfTwoCustomers_WhenSelectingCustomersInList_ReturnExpectedCustomers()
        {
            var mockCustomerService = new Mock<ICustomerService>();
            var customer = new Customer
            {
                CustomerId = "MANDA",
                ContactName = "Nish Mandal",
                CompanyName = "Sparta Global",
                City = "Birmingham"
            };
            var customer1 = new Customer
            {
                CustomerId = "YE",
                ContactName = "Kanye West",
                CompanyName = "Kanye West Church",
                City = "Murica"
            };

            mockCustomerService.Setup(cs => cs.GetCustomerById(customer.CustomerId)).Returns(customer);

            _sut = new CustomerManager(mockCustomerService.Object);
            _sut.SetSelectedCustomer(customer);
            Assert.That(_sut.SelectedCustomer.ContactName, Is.EqualTo("Nish Mandal"));
            Assert.That(_sut.SelectedCustomer.City, Is.EqualTo("Birmingham"));

            //_sut = new CustomerManager(mockCustomerService1.Object);
            _sut.SetSelectedCustomer(customer1);
            Assert.That(_sut.SelectedCustomer.ContactName, Is.EqualTo("Kanye West"));
            Assert.That(_sut.SelectedCustomer.City, Is.EqualTo("Murica"));
        }

        // Jon Crofts
        [Test]
        public void SetSelectedCustomer_ToInvalidCustomer_WillThrowAnInvalidCastException()
        {
            var mockCustomerService = new Mock<ICustomerService>();
            _sut = new CustomerManager(mockCustomerService.Object);
            Assert.That(() => _sut.SetSelectedCustomer("Invalid"), Throws.InstanceOf<InvalidCastException>());
        }
        #endregion
    }
}

