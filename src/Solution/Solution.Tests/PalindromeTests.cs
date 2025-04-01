using Solution.Palindrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Tests;

[TestClass]
public class PalindromeTests
{
    [TestMethod]
    public void CekPalindrom_WithPalindrome_ReturnsTrue()
    {
        // Arrange
        var input = "Kasur ini rusak";

        // Act
        var result = PalindromeChecker.CekPalindrom(input);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void CekPalindrom_WithMixedCaseAndPunctuation_ReturnsTrue()
    {
        // Arrange
        var input = "Ibu Ratna antar ubi";

        // Act
        var result = PalindromeChecker.CekPalindrom(input);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void CekPalindrom_WithNonPalindrome_ReturnsFalse()
    {
        // Arrange
        var input = "Hello World";

        // Act
        var result = PalindromeChecker.CekPalindrom(input);

        // Assert
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void CekPalindrom_WithEmptyString_ReturnsTrue()
    {
        // Arrange
        var input = "";

        // Act
        var result = PalindromeChecker.CekPalindrom(input);

        // Assert
        Assert.IsTrue(result, "Empty string is considered a palindrome.");
    }
}