﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Academy.Models;
using Academy.Core.Providers;

namespace Academy.Tests.ModelsTests.CourseTests
{
    [TestFixture]
    public class StartingDateTests
    {
        [Test]
        public void StartingDate_WhenPassedValueIsInvalid_ShouldThrowArgumentNullException()
        {
            // Arrange
            var endDate = new DateTime(2017, 7, 27);
            var courseName = "Math";
            var numberOfLectures = 3;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => new Course(courseName, numberOfLectures, null, endDate));
        }

        [Test] 
        public void StartingDate_WhenPassedValueIsValid_ShouldNotThrowException()
        {
            // Arrange
            var startDate = new DateTime(2017, 7, 7);
            var endDate = new DateTime(2017, 7, 27);
            var courseName = "Math";
            var numberOfLectures = 3;

            // Act & Assert
            Assert.DoesNotThrow(() => new Course(courseName, numberOfLectures, startDate, endDate));
        }

        [Test]
        public void StartingDate_WhenPassedValueIsValid_ShouldCorrectlyAssignPassedValue()
        {
            // Arrange
            var startDate = new DateTime(2017, 7, 7);
            var endDate = new DateTime(2017, 7, 27);
            var courseName = "Math";
            var numberOfLectures = 6;

            // Act
            var course = new Course(courseName, numberOfLectures, startDate, endDate);

            // Act & Assert
            Assert.AreEqual(startDate, course.StartingDate);
        }
    }
}
