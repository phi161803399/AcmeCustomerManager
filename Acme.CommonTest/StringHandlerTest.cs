﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Common;

namespace Acme.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesValid()
        {
            // Arrange
            var source = " Sonic   Screwdriver  ";
            var expected = "Sonic Screwdriver";

            //var handler = new StringHandler();

            // Act
            //var actual = handler.InsertSpaces(source);
            var actual = source.InsertSpaces();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
