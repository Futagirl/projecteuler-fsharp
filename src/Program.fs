let rnd = new System.Random()

let stopWatch = System.Diagnostics.Stopwatch.StartNew()
if rnd.Next() % 2 = 0 then
    printfn $"4 {euler8.result}"
else
    printfn $"4_ {euler8.result}"

stopWatch.Stop()

printfn $"%f{stopWatch.Elapsed.TotalMilliseconds}"

// euler2e.e02
