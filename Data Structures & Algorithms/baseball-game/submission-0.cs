public class Solution {
    public int CalPoints(string[] operations) {
        List<int> arr = new List<int>();
        int sum=0;
        int lastnum=0;

        foreach (string op in operations) {
                switch(op){
                    case"+":
                    arr.Add(arr[arr.Count-1]+arr[arr.Count-2]);
                    break;
                    case"D":
                     arr.Add(arr[arr.Count-1]*2);
                     break;
                    case"C":
                     arr.RemoveAt(arr.Count-1);
                     break;
                    default:

                    arr.Add(int.Parse(op));
                    break
;
                }
            
            }
            return arr.Sum();
        }
    }