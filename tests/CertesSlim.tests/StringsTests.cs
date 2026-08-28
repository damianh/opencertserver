namespace CertesSlim.Tests;

using System.Globalization;
using CertesSlim.Properties;
using Xunit;

public class StringsTests
{
    [Fact]
    public void CanCreateInstance()
    {
        _ = new Strings();
    }

    [Fact]
    public void CanGetSetCulture()
    {
        Strings.Culture = CultureInfo.GetCultureInfo("fr-CA");
        Assert.Equal(CultureInfo.GetCultureInfo("fr-CA"), Strings.Culture);
    }
}