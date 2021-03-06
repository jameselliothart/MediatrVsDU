﻿using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ExampleMediatR.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IMediator mediator;

        public WeatherForecastController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("{day}")]
        public async Task<IActionResult> Get(string day)
        {
            var query = new WeatherQuery { Day = day };
            WeatherForecast result = await mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("{day}/{bad}")]
        public async Task<IActionResult> BadGet(string day, string bad)
        {
            var query = new BadQuery { Day = day, Bad = bad };
            string result = await mediator.Send(query);
            return Ok(result);
        }
    }
}
