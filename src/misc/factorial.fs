module misc

let inline factorial n =
    let nums = [1..n]
    List.reduce (fun acc n -> acc * n) nums