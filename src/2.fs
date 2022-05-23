module euler2

open System.Timers
open System.Threading
open System.Diagnostics

    let e02 =
        let stopWatch = System.Diagnostics.Stopwatch.StartNew()

        let fib =
            (0, 1)
            |> Seq.unfold (fun state ->
                if (snd state > 4000000) then
                    None
                else
                    Some(fst state + snd state, (snd state, fst state + snd state)))

        let isEven (x) = x % 2 = 0

        let search2 =
            Seq.filter isEven fib
            |> Seq.reduce (fun acc curr -> acc + curr)

        printfn "%d" search2

        stopWatch.Stop()

        printfn $"%f{stopWatch.Elapsed.TotalMilliseconds}"
