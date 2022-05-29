module mymath

let factorial n =
    let nums = [ 1..n ]
    List.reduce (fun acc n -> acc * n) nums

let sieveOfEratoshenes top_number = 
    let numbers = [ yield 2
                    for i in 3..2..top_number -> i ]
    let rec sieve ns = 
        match ns with
        | [] -> []
        | x::xs when x*x > top_number -> ns
        | x::xs -> x::sieve (List.filter(fun y -> y%x <> 0) xs)
    sieve numbers 
