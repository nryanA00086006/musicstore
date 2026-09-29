namespace EmeraldMusicTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(1850)]
    [TestCase(1900)]
    [TestCase(2026)]
    public void AcceptedYears_AreBetween1850And2026(int year)
    {
        Assert.That(year, Is.InRange(1850, 2026));
    }
}
