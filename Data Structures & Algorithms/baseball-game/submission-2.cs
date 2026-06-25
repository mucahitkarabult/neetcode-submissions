public class Solution {
    public int CalPoints(string[] operations) {
       Stack<int> stack = new Stack<int>();
       int res= 0;
        foreach(string op in operations){

            switch(op){
                case "+" :
                int top = stack.Pop();
                int second = stack.Peek();
                int sum=top+second;
                 stack.Push(top);
                stack.Push(sum);
                res+=sum;
                break;

                case "D" :
                 int score  = stack.Peek()*2;
                 res+=score;
                 stack.Push(score);

                break;

                case "C" :
                      res-=stack.Pop();
                break;

                default:
                stack.Push(int.Parse(op));
                res+=int.Parse(op);
                break;


            }
        }
        return res;

    }
}