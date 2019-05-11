module Leap

let leapYear (year:int):bool =
     year % 4 = 0 && (year % 100 <> 0 || year % 400 = 0)

// ==============================================
(*
  let leapYear (year:int):bool =
     match year with
     | year when year % 4 <> 0 -> false
     | year when year % 100 <> 0 -> true
     | year when year % 400 <> 0   -> false
     | _ -> true
*)

// ==============================================
// let (|DivBy|_|) b a =
//     if a % b = 0 then Some(DivBy)
//     else None

// let isLeapYear year =
//     match year with
//     | DivBy 400 -> true
//     | DivBy 100 -> false
//     | DivBy 4 -> true
//     | _ -> false
// ==============================================

// let isLeapYear x =
//     match (x % 4, x % 100, x % 400) with
//     | (_, _, 0) -> true
//     | (_, 0, _) -> false
//     | (0, _, _) -> true
//     | _ -> false
