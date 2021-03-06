using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace ExampleMediatR.Controllers
{
    public class WeatherQueryHandler : IRequestHandler<WeatherQuery, WeatherForecast>
    {
        public Task<WeatherForecast> Handle(WeatherQuery request, CancellationToken cancellationToken)
        {
            var rng = new Random();
            var weather = new WeatherForecast
            {
                Date = DateTime.Now,
                TemperatureC = rng.Next(-20,55),
                Summary = $"Weather for {request.Day}"
            };
            return Task.FromResult(weather);
        }
    }
}