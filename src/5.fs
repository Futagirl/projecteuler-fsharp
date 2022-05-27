module euler5

open FSharp.Collections.ParallelSeq

let numbers = [ 2L .. 20L ]

let findMultiple (nums: list<int64>) =
    let highestDivisor = List.max nums

    let isDivisibleBy (divisor: int64) dividend = dividend % divisor = 0L

    let numsToCheck =
        List.foldBack
            (fun num acc ->
                if Seq.exists (isDivisibleBy num) acc then
                    acc
                else
                    num::acc)
            nums
            [ highestDivisor ]

    let multiples = Seq.initInfinite (fun i -> (highestDivisor * ((int64) i + 1L)))

    let isDivisibleByAll multiple =
        Seq.forall (fun num -> multiple % num = 0L) numsToCheck

    Seq.find isDivisibleByAll multiples

let result = findMultiple numbers
