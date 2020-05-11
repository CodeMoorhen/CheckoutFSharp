namespace BackToTheCheckout

open Microsoft.FSharp.Collections

module BackToTheCheckout =
    type ItemCounts = { CountOfA: int; CountOfB: int;
                        CountOfC: int; CountOfD: int;}

    let getValueForInvidualItem x counts = 
        match x with 
        | "A" -> {counts with CountOfA = counts.CountOfA + 1} 
        | "B" -> {counts with CountOfB = counts.CountOfB + 1}
        | "C" -> {counts with CountOfC = counts.CountOfC + 1}
        | "D" -> {counts with CountOfD = counts.CountOfD + 1}
        | _ -> failwith "Problem: invalid input"
    
    let rec myFunction x counts = 
        match x with
        | head :: tail -> getValueForInvidualItem head counts |> myFunction tail 
        | [] -> counts
    
    let calculateTotal (counts:ItemCounts) = 
        let CalculateTotalOfAs num = 
            let quotient = num / 3
            let remainder = num % 3
            (quotient * 130) + remainder * 50
            
        let CalculateTotalOfBs num = 
            let quotient = num / 2
            let remainder = num % 2
            (quotient * 45) + remainder * 30

        let CalculateTotalOfCs noOfCs = noOfCs * 20
        let CalculateTotalOfDs noOfDs = noOfDs * 15

        CalculateTotalOfAs counts.CountOfA + CalculateTotalOfBs counts.CountOfB + CalculateTotalOfCs counts.CountOfC + CalculateTotalOfDs counts.CountOfD

    let Total x = 
        let counts = myFunction x {CountOfA=0; CountOfB=0; CountOfC=0; CountOfD=0}

        counts |> calculateTotal