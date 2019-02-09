module LeapYear

let isLeapYear (year: int): bool =
    match year with
    | n when n % 400 = 0 -> true
    | n when n % 100 = 0 -> false
    | n when n % 4 = 0 -> true
    | _ -> false
