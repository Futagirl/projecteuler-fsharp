module euler6

let numbers = [ 1..100 ]

let accSquareAndMultiply (addSum, powSum) num =
    let square = int ((float num) ** 2)
    (addSum + num, powSum + square)

// let a = accSquareAndMultiply (0,0) 1

let result = 
    let sum, squareSum = List.fold accSquareAndMultiply (0, 0) numbers
    let sumSquare = float sum ** 2
    (sumSquare, squareSum, abs (int sumSquare - squareSum))
