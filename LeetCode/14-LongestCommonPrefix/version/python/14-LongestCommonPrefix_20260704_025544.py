# Last updated: 7/4/2026, 2:55:44 AM
1class Solution:
2    def longestCommonPrefix(self, strs: List[str]) -> str:
3        if not strs:
4            return ""
5        
6        # Sort the strings - the common prefix will be a prefix of the first and last strings
7        strs.sort()
8        first = strs[0]
9        last = strs[-1]
10        
11        # Find the common prefix between first and last
12        i = 0
13        while i < len(first) and i < len(last) and first[i] == last[i]:
14            i += 1
15        
16        return first[:i]