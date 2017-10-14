module Raindrops

let factors = [(3, "Pling"); (5, "Plang"); (7, "Plong")];

let getMessages number factors =
    factors
    |> List.filter (fun (factor, _) -> number % factor = 0)
    |> List.map (fun (_, message) -> message)

let convert (number: int): string =
    match getMessages number factors with
    | [] -> string number
    | messages -> String.concat "" messages
