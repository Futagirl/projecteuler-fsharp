module euler4

open System.Linq

let (|Palindromic|NotPalindromic|) x =
    if x.ToString().ToCharArray() = x.ToString().Reverse().ToArray() then
        Palindromic
    else
        NotPalindromic

let nums = List.rev [ 100..999 ]

let res =
    List.allPairs nums nums
    |> List.map (fun (x, y) -> x * y)
    |> List.filter (fun x ->
        match x with
        | Palindromic -> true
        | NotPalindromic -> false)
    |> List.max


let result = $"{res}"
