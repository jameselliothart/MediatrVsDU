namespace ExampleDU.Controllers

open System
open System.Collections.Generic
open System.Linq
open System.Threading.Tasks
open Microsoft.AspNetCore.Mvc
open Microsoft.Extensions.Logging
open ExampleDU

[<ApiController>]
[<Route("[controller]")>]
type WeatherForecastController () =
    inherit ControllerBase()

    [<HttpGet("{day}")>]
    member this.Get(day) =
        Weather day |> mediator |> this.Ok
