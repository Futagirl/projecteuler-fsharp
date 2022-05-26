module euler4_

open System.Linq

let res =
    let mutable max = 0

    let (|Palindromic|NotPalindromic|) x =
        if x.ToString().ToCharArray() = x.ToString().Reverse().ToArray() then
            Palindromic
        else
            NotPalindromic

    let nums = List.rev [ 100..999 ]

    for a in nums do
        for b in nums do
            let p = a * b

            max <-
                match p with
                | Palindromic when p > max -> p
                | _ -> max

    max
// let res =
//     List.allPairs  nums nums
//     |> List.rev
//     |> List.map (fun (x, y) ->
//         x * y)
//     |> List.filter(fun x -> match x with |Palindromic -> true |NotPalindromic -> false)
//     |> List.max


let result = $"{res}"
