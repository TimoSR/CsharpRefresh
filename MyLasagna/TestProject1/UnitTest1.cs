using MyLasagna;
namespace TestProject1;

public class Tests
{
    private readonly Lasagna _lasagna = new Lasagna();

    [Test]
    public void ExpectedMinutesInOvenTest()
    {
        Assert.That(_lasagna.ExpectedMinutesInOven(), Is.EqualTo(40));
    }

    [Test]
    public void RemainingMinutesInOvenTest()
    {
        Assert.That(_lasagna.RemainingMinutesInOven(20), Is.EqualTo(20));
    }

    [Test]
    public void PreparationTimeInMinutesTest()
    {
        Assert.That(_lasagna.PreparationTimeInMinutes(3), Is.EqualTo(6));
    }
    
    
}