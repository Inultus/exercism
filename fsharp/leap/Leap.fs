module Leap

let isDivisibleBy divisor dividend = 
     dividend % divisor = 0

let leapYear (year:int):bool =
     isDivisibleBy 4 year && not(isDivisibleBy 100 year) || isDivisibleBy 400 year

