module Hamming

let distance (strand1: string) (strand2: string): int =
    Seq.map2((=)) strand1 strand2 |> Seq.sumBy(fun bool -> match bool with
                                                            | true  -> 0
                                                            | false -> 1)

(*
let compute x y =
    let folder diff a b =
        if a <> b then diff + 1 else diff
    Seq.fold2 folder 0 x y


let compute a b =
    Seq.zip a b
    |> Seq.filter (fun (x, y) -> x <> y)
    |> Seq.length

let hamming s1 s2 = Seq.map2((=)) s1 s2 |> Seq.sumBy(fun b -> if b then 0 else 1)
*)
