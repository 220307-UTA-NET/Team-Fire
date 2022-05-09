using Microsoft.EntityFrameworkCore;
using Project2EntityFramework;
using Project2EntityFramework.Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace Proejct2EntityFrameworkTest
{
    public class UnitTest1
    {
        [Fact]
        public void CustomerTest()
        {
            //Arrange
            Customer test = new Customer(6, "sdfnisgowhbos" ,"June", "Lee", "400 square ave", "","Arlington","TX","76011","817-561-4795","JuneLee@gmail.com");

            //Act
            int actual1 = test.Customer_ID;
            string actual2 = test.PWord;
            string actual3 = test.FirstName;
            string actual4 = test.LastName;
            string actual5 = test.Address1;
            string actual6 = test.Address2;
            string actual7 = test.City;
            string actual8 = test.StateAbb;
            string actual9 = test.Zip;
            string actual10 = test.Phone;
            string actual11 = test.Email;

            //Assert
            int expected1 = 6;
            string expected2 = "sdfnisgowhbos";
            string expected3 = "June";
            string expected4 = "Lee";
            string expected5 = "400 square ave";
            string expected6 = "";
            string expected7 = "Arlington";
            string expected8 = "TX";
            string expected9 = "76011";
            string expected10 = "817-561-4795";
            string expected11 = "JuneLee@gmail.com";
            Assert.Equal(expected1, actual1);
            Assert.Equal(expected2, actual2);
            Assert.Equal(expected3, actual3);
            Assert.Equal(expected4, actual4);
            Assert.Equal(expected5, actual5);
            Assert.Equal(expected6, actual6);
            Assert.Equal(expected7, actual7);
            Assert.Equal(expected8, actual8);
            Assert.Equal(expected9, actual9);
            Assert.Equal(expected10, actual10);
            Assert.Equal(expected11, actual11);
        }

        [Fact]
        public void CardTest()
        {
            //Arrange
            Card test = new Card(6, 478126930245, "2022/03/07", 1000, 2000, 5);

            //Act
            int actual1 = test.Card_ID;
            long actual2 = test.Card_Number;
            string actual3 = test.PurchaseDate;
            decimal actual4 = test.InitialBalance;
            decimal actual5 = test.CurrentBalance;
            int actual6 = test.Customer;

            //Assert
            int expected1 = 6;
            long expected2 = 478126930245;
            string expected3 = "2022/03/07";
            decimal expected4 = 1000;
            decimal expected5 = 2000;
            int expected6 = 5;
            Assert.Equal(expected1, actual1);
            Assert.Equal(expected2, actual2);
            Assert.Equal(expected3, actual3);
            Assert.Equal(expected4, actual4);
            Assert.Equal(expected5, actual5);
            Assert.Equal(expected6, actual6);
        }

       /* [Fact]
        public void CustomerUpdateTest()
        {
            Customer test = new Customer(6, "sdfnisgowhbos", "June", "Lee", "400 square ave", "", "Arlington", "TX", "76011", "817-561-4795", "JuneLee@gmail.com");
        }*/
    }  
}