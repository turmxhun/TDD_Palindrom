using System;
using Xunit;

public class PalindromEllenorTests
{
    [Fact]
    public void EgyszeruPalindrom_ShouldReturnTrue_ForSimplePalindrome()
    {
        // Arrange
        PalindromEllenor target = new PalindromEllenor();

        // Act
        bool result = target.EgyszeruPalindrom("eke");

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void EgyszeruPalindrom_ShouldReturnFalse_ForNonPalindrome()
    {
        // Arrange
        PalindromEllenor target = new PalindromEllenor();

        // Act
        bool result = target.EgyszeruPalindrom("alma");

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void EgyszeruPalindrom_ShouldReturnTrue_ForEmptyString()
    {
        // Arrange
        PalindromEllenor target = new PalindromEllenor();

        // Act
        bool result = target.EgyszeruPalindrom("");

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void EgyszeruPalindrom_ShouldThrowException_ForNullInput()
    {
        // Arrange
        PalindromEllenor target = new PalindromEllenor();

        // Act & Assert
        Assert.Throws<NemMegfeleloParameterException>(() => target.EgyszeruPalindrom(null));
    }

    [Fact]
    public void OsszetettPalindrom_ShouldReturnTrue_ForSimplePalindromeSentence()
    {
        // Arrange
        PalindromEllenor target = new PalindromEllenor();

        // Act
        bool result = target.OsszetettPalindrom("Ló szava szól!");

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void OsszetettPalindrom_ShouldReturnTrue_ForEmptyString()
    {
        // Arrange
        PalindromEllenor target = new PalindromEllenor();

        // Act
        bool result = target.OsszetettPalindrom("");

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void OsszetettPalindrom_ShouldReturnFalse_ForNonPalindromeSentence()
    {
        // Arrange
        PalindromEllenor target = new PalindromEllenor();

        // Act
        bool result = target.OsszetettPalindrom("This is not a palindrome.");

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void OsszetettPalindrom_ShouldThrowException_ForNullInput()
    {
        // Arrange
        PalindromEllenor target = new PalindromEllenor();

        // Act & Assert
        Assert.Throws<NemMegfeleloParameterException>(() => target.OsszetettPalindrom(null));
    }
}
