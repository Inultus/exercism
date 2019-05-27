module Anagram (anagramsFor) where
import Data.Char
import Data.List

anagramsFor :: String -> [String] -> [String]
anagramsFor xs xss = filter (anagramCompare xs) xss

anagramCompare word1 word2 = wordLower word1 /= wordLower word2 && sort (wordLower word1) == sort (wordLower word2)

wordLower = map toLower
