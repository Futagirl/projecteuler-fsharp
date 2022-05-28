module euler9

let num = 1000

// a**2 + b**2 = c**2 -> a+b+c = 1000 -> 500**2 + 0**2 = 500**2 ? -> sqrt(c) > a || b
//
// a+b+c = 1000
// c = sqrt(a**2 + b**2)
// a+b+(sqrt(a**2 + b**2)) = 1000
// a**2 + b**2 + (a**2 + b**2)**2 = 1000**2
// a**2 + b**2 + (a**2 + b**2)**2 = 1000**2
// a**2 + b**2 + ((a**2 + b**2) * (a**2 + b**2)) = 1000**2
// a**2 + b**2 + a**4 + 2b**2*a**2 + b**4 = 1000**2
// a + b + a**2 + sqrt(2)*b*a + b*2 = 1000
//

let nums = [ 1.0 .. 500. ]

let combinations = List.allPairs nums nums

let pythagoras (a: float) (b: float) = sqrt (a ** 2 + b ** 2)

let result =
    List.filter (fun (a, b) -> a + b + (sqrt (float a ** 2 + float b ** 2)) = 1000.) combinations
    |> List.head
    |> (fun (a, b) -> a * b * (pythagoras a b))
