module Accumulate

let rec accumulate<'a, 'b> (func: 'a -> 'b) (input: 'a list): 'b list =
    let rec transform list acc =
        match list with
        | head :: tail -> transform tail (func head::acc)
        | [] -> List.rev acc
    transform input []
