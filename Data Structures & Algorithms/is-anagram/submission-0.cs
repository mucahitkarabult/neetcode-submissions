public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length!=t.Length)
            return false;
        int[] frequency = new int[26];
        foreach(var c in s){
            frequency[c-'a']++;
        }
        foreach(var c in t){
             frequency[c-'a']--;
        }
     
        foreach (int num in frequency)
        {
            if (num != 0)
                return false;
        }
            return true;
    }
}
