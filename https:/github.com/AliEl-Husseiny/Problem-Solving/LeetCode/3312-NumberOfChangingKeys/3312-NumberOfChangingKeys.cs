// Last updated: 7/2/2026, 2:47:57 AM
public class Solution {
    public int CountKeyChanges(string s) {
        int counter = s.Length; 
		int result = 0;
        int m = 'a' - 'A';
		while(counter > 1)
		{
			int a = (s[counter-2] > 'Z')? s[counter-2] - m : s[counter-2];
            int b = (s[counter-1] > 'Z')? s[counter-1] - m : s[counter-1];
            if(a != b)
				++result;
			--counter;
		}
	return result;
    }
}