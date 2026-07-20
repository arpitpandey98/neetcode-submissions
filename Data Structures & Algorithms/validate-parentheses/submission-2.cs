public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        Dictionary<char,char> pair = new Dictionary<char,char>(){
            { ')','('},
            {']', '['},
            {'}','{'}
        };

        foreach(char c in s){
            if (pair.ContainsKey(c)){
                if(stack.Count > 0 && stack.Peek() == pair[c]){
                    stack.Pop();
                }
                else
                return false;
            }
            else{
                stack.Push(c);
            }
        }

        return stack.Count == 0;

    }
}
