public class Solution {
    public bool hasDuplicate(int[] nums) {
       Dictionary<int, int> counter = new Dictionary<int, int>(); 
        foreach(var i in nums){
            if(counter.ContainsKey(i))
            return true;
            counter.Add(i,1);

        }
        return false;
    }
}