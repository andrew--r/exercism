module Bob

let (|Silence|Yell|Question|Other|) (input: string) =
    match true with
    | _ when input.Trim() = "" -> Silence
    | _ when input.ToUpper() = input && input.ToLower() <> input -> Yell
    | _ when input.EndsWith("?") -> Question
    | _ -> Other

let hey (input: string): string =
    match input with
    | Silence -> "Fine. Be that way!"
    | Yell -> "Whoa, chill out!"
    | Question -> "Sure."
    | _ -> "Whatever."
