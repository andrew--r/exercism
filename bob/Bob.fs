module Bob

let hey (input: string): string =
    match input with
    | s when s.Trim() = "" -> "Fine. Be that way!"
    | s when s |> String.exists(System.Char.IsLetter) && s.ToUpper() = s -> "Whoa, chill out!"
    | s when s.EndsWith("?") -> "Sure."
    | _ -> "Whatever."
