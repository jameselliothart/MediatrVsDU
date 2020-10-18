namespace ExampleDU

open System
open System.Threading.Tasks

[<AutoOpen>]
module Weather =

    type Query =
    | Weather of day: string

    let mediator = function
        | Weather d ->
            let rng = Random()
            {
                Date = DateTime.Now;
                TemperatureC = rng.Next(-20,55);
                Summary = sprintf "Weather for %s" d
            } |> Task.FromResult
