using NUnit.Framework;

[TestFixture]
public class PalindromEllenorTests
{
    [Test]
    public void EgyszeruPalindrom_ShouldReturnTrue_ForPalindromeWord()
    {
        // Arrange
        PalindromEllenor ellenor = new PalindromEllenor();

        // Act
        bool result = ellenor.EgyszeruPalindrom("radar");

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void EgyszeruPalindrom_ShouldReturnTrue_ForEmptyString()
    {
        // Arrange
        PalindromEllenor ellenor = new PalindromEllenor();

        // Act
        bool result = ellenor.EgyszeruPalindrom("");

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void EgyszeruPalindrom_ShouldReturnFalse_ForNonPalindromeWord()
    {
        // Arrange
        PalindromEllenor ellenor = new PalindromEllenor();

        // Act
        bool result = ellenor.EgyszeruPalindrom("apple");

        // Assert
        Assert.IsFalse(result);
    }

    [Test]
    public void OsszetettPalindrom_ShouldReturnTrue_ForSimplePalindromeSentence()
    {
        // Arrange
        PalindromEllenor ellenor = new PalindromEllenor();

        // Act
        bool result = ellenor.OsszetettPalindrom("Eva, látta Bátsat élõk és élõk tátSáb táttaleval AVE.");

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void OsszetettPalindrom_ShouldReturnTrue_ForEmptyString()
    {
        // Arrange
        PalindromEllenor ellenor = new PalindromEllenor();

        // Act
        bool result = ellenor.OsszetettPalindrom("");

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void OsszetettPalindrom_ShouldReturnFalse_ForNonPalindromeSentence()
    {
        // Arrange
        PalindromEllenor ellenor = new PalindromEllenor();

        // Act
        bool result = ellenor.OsszetettPalindrom("This is not a palindrome.");

        // Assert
        Assert.IsFalse(result);
    }
}
