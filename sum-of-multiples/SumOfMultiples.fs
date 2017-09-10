module SumOfMultiples

let isMultipleOf (numbers: int list) (target: int): bool =
    numbers
    |> List.exists (fun number -> target % number = 0)

let sumOfMultiples (numbers: int list) (upperBound: int): int =
    [1..(upperBound - 1)]
    |> List.filter (isMultipleOf numbers)
    |> List.sum
