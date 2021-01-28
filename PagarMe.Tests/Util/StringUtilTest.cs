﻿using PagarMe.Utils;
using Xunit;

namespace PagarMe.Tests.Util
{
    public class StringUtilTest
    {
        [Fact]
        public void Should_Transform_String_To_SnakeCase()
        {
            // Arrange
            var text = "AnExample";

            // Act
            var result = StringUtil.ToSnakeCase(text);

            // Assert
            Assert.Equal("an_example", result);
        }
    }
}
