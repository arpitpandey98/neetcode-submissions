public class Solution {
    public bool IsAnagram(string s, string t) {
       if (s.Length == t.Length){

        int[] count = new int[26];

        foreach(char a in s){
            count[a - 'a']++;
        }
        foreach(char b in t){
            count[b - 'a']--;
        }
        foreach(int ct in count){
            if(ct > 0)
            return false;
        }


        return true;
       }
       return false;
    }
}
