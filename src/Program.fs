let rnd = new System.Random()

let stopWatch = System.Diagnostics.Stopwatch.StartNew()
if rnd.Next() % 2 = 0 then
    printfn $"4 {euler4.result}"
else
    printfn $"4_ {euler4_.result}"

stopWatch.Stop()

printfn $"%f{stopWatch.Elapsed.TotalMilliseconds}"

// euler2e.e02
