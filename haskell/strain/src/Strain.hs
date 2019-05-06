module Strain (keep, discard) where

discard :: (a -> Bool) -> [a] -> [a]
discard p xs = [x | x <- xs, p x == False ]

keep :: (a -> Bool) -> [a] -> [a]
keep p xs = [x | x <- xs, p x == True ]

{-- other solution
keep :: (a -> Bool) -> [a] -> [a]
keep _ [] = []
keep p (x:xs)
  | p x = x : keep p xs
  | otherwise = keep p xs

discard :: (a -> Bool) -> [a] -> [a]
discard p = keep (not . p)
--}
