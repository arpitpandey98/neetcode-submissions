public class Solution {
    public bool IsAnagram(string s, string t) {
      if(s.Length == t.Length){
      Dictionary<char,int> char_in_s = new Dictionary<char,int>()  ;
      Dictionary<char,int> char_in_t = new Dictionary<char,int>()  ;

      for(int i=0 ; i< s.Length ;i++){
        if(char_in_s.ContainsKey(s[i])){
              char_in_s[s[i]] +=1;
        }
        else{
            char_in_s.Add(s[i],1);
        }
        if(char_in_t.ContainsKey(t[i])){
              char_in_t[t[i]] +=1;
        }
        else{
            char_in_t.Add(t[i],1);
        }
      }

        foreach(var items in char_in_s){
           if(! (char_in_t.ContainsKey(items.Key) && char_in_t[items.Key] == items.Value)){
              return false;
           }

        }
        return true;

      }
      return false;
    }
}
