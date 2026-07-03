class Solution:
    def longestCommonPrefix(self, strs: List[str]) -> str:
        if not strs:
            return ""
        
        # Sort the strings - the common prefix will be a prefix of the first and last strings
        strs.sort()
        first = strs[0]
        last = strs[-1]
        
        # Find the common prefix between first and last
        i = 0
        while i < len(first) and i < len(last) and first[i] == last[i]:
            i += 1
        
        return first[:i]