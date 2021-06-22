using System;
using Xunit;
using FirstResponsiveWebAppSoulinthavong.Models;

namespace CalculateAgeUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void CalculateMyAge()
        {
            //Arrange
            CalculateAge ca = new CalculateAge();
            string expected, actual;
            string name = "Jake";
            ca.Name = name;
            ca.BirthYear = 1995;
            expected = name + ", you will be 26 by the end of 2021.";
            //Act
            actual = ca.AgeThisYear();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TrueTest()
        {
            //Arrange
            CalculateAge ca = new CalculateAge();
            string expected, actual;
            string name = "Jake";
            ca.Name = name;
            ca.BirthYear = 1995;
            expected = name + ", you will be 26 by the end of 2021.";
            //Act
            actual = ca.AgeThisYear();
            //Assert
            Assert.True(expected == actual);
        }

        [Fact]
        public void FalseTest()
        {
            //Arrange
            CalculateAge ca = new CalculateAge();
            string expected, actual;
            string name = "Jake";
            ca.Name = name;
            ca.BirthYear = 2000;
            expected = name + ", you will be 26 by the end of 2021.";
            //Act
            actual = ca.AgeThisYear();
            //Assert
            Assert.False(expected == actual);
        }
    }
}
