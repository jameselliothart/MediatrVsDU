namespace ExampleDU

open System
open System.Threading.Tasks

[<AutoOpen>]
module Weather =

    type Query =
    | Weather of day: string
    | Bad of day: string * bad: string

    let mediator = function
        | Weather d ->
            let rng = Random()
            {
                Date = DateTime.Now;
                TemperatureC = rng.Next(-20,55);
                Summary = sprintf "Weather for %s" d
            } |> Task.FromResult
