module Raindrops

let factors = [(3, "Pling"); (5, "Plang"); (7, "Plong")];

let foldMessages acc (factor,message) = sprintf "%s%s" acc message

let messageOrNumber number message =
    match message with
    | "" -> string number
    | _ -> message

let convert (number: int): string =
    factors
    |> List.filter (fun (factor, message) -> number % factor = 0)
    |> List.fold foldMessages ""
    |> messageOrNumber number
