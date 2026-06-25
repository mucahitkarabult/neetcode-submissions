public class Solution {
    public bool IsValid(string s) {
      Dictionary<char,char> dict = new(){
       { ')', '(' },
    { '}', '{' },
    { ']', '[' }
      };
      Stack<char> stack = new ();

      foreach(char c in s  ){
        if(!dict.ContainsKey(c)){
            stack.Push(c);
        }
        else{
            if(stack.Count <1 || stack.Pop()!= dict[c])
                return false;
        }

      }
      return stack.Count == 0 ;

    }
}
