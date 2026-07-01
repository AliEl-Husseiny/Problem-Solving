// Last updated: 7/2/2026, 2:47:59 AM
public class Solution {
    public IList<int> FindWordsContaining(string[] words, char x) {
       List<int> Indices = new List<int>();
		for(int i = 0; i < words.Length; i++)
		{
			for(int j = 0; j < words[i].Length; j++)
			{
				if(words[i][j] == x)
				{
					Indices.Add(i);
					break;
				}
			}
		}
		return Indices.ToArray();
    }
}