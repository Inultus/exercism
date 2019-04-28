

def is_pangram(sentence):
    alphabet_lower = "abcdefghijklmnopqrstuvwxyz"
    sentence_lowered = str.lower(sentence)
    letters = ""
    for char in sentence_lowered:
        if char in alphabet_lower:
            letters += char
    for char in alphabet_lower:
        if char not in sentence_lowered:
            return False

    return True

"""Better solution

from string import ascii_lowercase

ALPHABET = set(ascii_lowercase)

def is_pangram(string):
    return ALPHABET.issubset(string.lower())

"""

"""
from string import ascii_lowercase


def is_pangram(sentence):
    sentence_set = set(sentence.lower())
    alpha_set = set(ascii_lowercase)

    if alpha_set - sentence_set == set([]):
        return True

    return False
"""
