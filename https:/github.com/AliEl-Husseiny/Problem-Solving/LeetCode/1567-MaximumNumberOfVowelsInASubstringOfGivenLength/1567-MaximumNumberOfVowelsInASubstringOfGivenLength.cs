// Last updated: 7/2/2026, 2:49:30 AM
public class Solution {
    public int MaxVowels(string s, int k) {
        int cnt=0;
        int ans=0;
        int[] arr=new int[s.Length];
        for(int i=0;i<s.Length;i++){
            if(s[i]=='a'||s[i]=='i'||s[i]=='u'||s[i]=='o'||s[i]=='e'){
                cnt++;
            }
            arr[i]=cnt;
        }
        ans=arr[k-1];
        int l=0;
        for(int i=k;i<s.Length;i++){
            ans=Math.Max(ans,arr[i]-arr[l++]);
        }
        return ans;
    }
}