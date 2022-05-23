module euler2e

let e02 =
    let stopWatch = System.Diagnostics.Stopwatch.StartNew()

    let fib =
        (0L, 1L)
        |> Seq.unfold (fun state ->
            if (snd state > 4000000) then
                None
            else
                Some(fst state + snd state, (snd state, fst state + snd state)))

    let isEven (x: int64) = x % 2L = 0
    let search1 list=
        Seq.reduce (fun acc curr ->
            (if (isEven curr) then
                 curr
             else
                 0L)
            + acc) list - 1L

    let res = search1 fib

    printfn "%d" res

    stopWatch.Stop()

    printfn $"%f{stopWatch.Elapsed.TotalMilliseconds}\n"
