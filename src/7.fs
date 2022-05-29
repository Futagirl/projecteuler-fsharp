module euler7

let result = 
    let primes = mymath.sieveOfEratoshenes 1000000
    primes[10000]
