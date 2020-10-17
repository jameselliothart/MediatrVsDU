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
            var r = new Random();
            var weather = new WeatherForecast
            {
                Date = DateTime.Now,
                TemperatureC = r.Next(0, 30),
                Summary = $"Weather for {request.Day}"
            };
            return Task.FromResult(weather);
        }
    }
}