module TwoFer

let getResponse (input: string option): string =
    defaultArg input "you"
    |> sprintf "One for %s, one for me."
