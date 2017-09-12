module TwoFer

let getResponse (input: string option): string =
    input
    |> Option.fold (fun _ name -> name) "you"
    |> sprintf "One for %s, one for me."
