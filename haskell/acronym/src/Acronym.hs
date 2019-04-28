
module Acronym (abbreviate) where

import Data.Char       (isLetter, toUpper)
import Data.List.Split (wordsBy)

abbreviate :: String -> String
abbreviate xs = (map (toUpper . head) . wordsBy (not . isLetter)) xs
