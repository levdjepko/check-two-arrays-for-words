#!/bin/python3

import math
import os
import random
import re
import sys
from collections import Counter

# Complete the checkMagazine function below.
def checkMagazine(magazine, note):
    a = Counter(magazine)
    # Checks all the words in magazine and Counts them: e.g.
    # {'One': 1, 'Two': 1, 'Thing': 1}
    
    b = Counter(note)
    # Same thing to count all the words in Note
    
    return 'Yes' if (a & b) == b else 'No'
    # a & b is an intersection of the two arrays a and b

if __name__ == '__main__':
    mn = input().split()

    m = int(mn[0])

    n = int(mn[1])

    magazine = input().rstrip().split()

    note = input().rstrip().split()

    print (checkMagazine(magazine, note))
