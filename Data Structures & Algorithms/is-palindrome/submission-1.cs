public class Solution {
    public bool IsPalindrome(string s) {

        // string str = "";

        // foreach(char c in s){
        //     if(char.IsLetterOrDigit(c)){
        //         str+= char.ToLower(c);
        //     }
        // }
        
        //  return str == new string(str.Reverse().ToArray()); 
        int l =0, r = s.Length -1;
        while (l<r){
            if(!isAlphanumeric(s[l])){
                l++;
            }
            else if(!isAlphanumeric(s[r])){
                r--;
            }
            else{
                if(!(char.ToLower(s[l]) == char.ToLower(s[r]))){
                    return false;
                }
                r--;
                l++;
            }
        }

        return true;
    }

    public bool isAlphanumeric(char ch){
        return ((ch>= 'a' && ch <= 'z') ||(ch>= 'A' && ch <= 'Z')||(ch>= '0' && ch <= '9'));
    }


}
