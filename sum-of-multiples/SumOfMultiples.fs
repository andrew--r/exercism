module SumOfMultiples

let sumOfMultiples (factors: int list) (upperBound: int): int =
    factors
    |> List.collect (fun factor -> [factor..factor..(upperBound - 1)])
    |> List.distinct
    |> List.sum
