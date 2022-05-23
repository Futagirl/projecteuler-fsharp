module euler1

let e01 =
   let limit = 999

   let divisibleBy dividend x = 
      x % dividend = 0
   
   let divisibleBy3 x =
       divisibleBy 3 x 

   let divisibleBy5 x =
       divisibleBy 5 x

   let numbers = [0..limit]
   
   let rec loop (nums: list<int>) (acc:int) =
      printf "%A\n" acc
      match nums with
      | head::tail ->
         match head with
         | x when divisibleBy3 x || divisibleBy5 x -> loop tail (acc+x)
         | _ -> loop tail acc
      | [] -> acc
      

   loop numbers 0


