using JenkinsSimpleApi.Controllers;


namespace JenkinsSimpleApi.Tests.Controllers;

public class WeatherForecastControllerTests
{
    private WeatherForecastController _sut;
    private Mock<ILogger<WeatherForecastController>> _loggerMock;

    [SetUp]
    public void Setup()
    {
        _loggerMock = new Mock<ILogger<WeatherForecastController>>();
        _sut = new WeatherForecastController(_loggerMock.Object);
    }

    [Test]
    public void Get_NoRepository_ReturnsWeatherForecasts()
    {
        var result = _sut.Get();

        Assert.That(result, Is.Not.Null);
        Assert.That(result.Count, Is.GreaterThan(0));
    }
}