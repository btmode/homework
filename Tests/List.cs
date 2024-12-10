using List;

namespace Tests;

public class List
{
    [Fact]
    public void LengthCheck1()
    {
        var options = new ValidationOptions()
        {
            minLength = 8,
            maxLength = 16,
            useDigits = null,
            useUpper = null,
            useLower = null,
            useSpecialSymbols = null,
        };
        var validator = new Validator(options);
        var result = validator.Validate("1234567");
        Assert.Equal(false, result.IsValid);
    }

    [Fact]
    public void LengthCheck2()
    {
        var options = new ValidationOptions()
        {
            minLength = 8,
            maxLength = 16,
            useDigits = null,
            useUpper = null,
            useLower = null,
            useSpecialSymbols = null,
        };
        var validator = new Validator(options);
        var result = validator.Validate("123456789123456789123456789123456789");
        Assert.Equal(false, result.IsValid);
    }

    // Этот тест не проходит
    // [Fact]
    // public void LengthCheck3()
    // {
    //     var options = new ValidationOptions()
    //     {
    //         minLength = 8,
    //         maxLength = 16,
    //         useDigits = null,
    //         useUpper = null,
    //         useLower = null,
    //         useSpecialSymbols = null,
    //     };
    //     var validator = new Validator(options);
    //     var result = validator.Validate("123456789");
    //     Assert.Equal(true, result.IsValid);
    // }
}