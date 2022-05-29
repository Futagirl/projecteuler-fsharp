module euler10

let result = 
    mymath.sieveOfEratoshenes 2000000
    |> List.sumBy int64