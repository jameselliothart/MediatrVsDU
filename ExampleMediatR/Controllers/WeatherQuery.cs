using MediatR;

namespace ExampleMediatR.Controllers
{
    public class WeatherQuery : IRequest<WeatherForecast>
    {
        public string Day { get; set; }
    }
}