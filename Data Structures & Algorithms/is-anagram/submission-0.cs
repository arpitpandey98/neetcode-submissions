public class Solution {
    public bool IsAnagram(string s, string t) {
     int[] string_s = new int[26];
     int[] string_t = new int[26];
     foreach(char c in s ){
        string_s[c - 'a']++;
     }
     foreach(char c in t ){
        string_t[c - 'a']++;
     }
     for(int i = 0;i<26;i++){
        if(string_s[i] != string_t[i]){
            return false;
        }
     }
     return true;
    }
}
