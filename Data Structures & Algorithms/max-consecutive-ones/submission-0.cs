public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int ans=nums[0];
        int temp=nums[0];
    for(int i =0; i<nums.Length-1;i++) {
        if(nums[i+1]==1) {
            temp++;
        }
        else{
            if(temp>ans){
                ans=temp;
            }
            temp=0;
        }
    }
    return ans>temp?ans:temp;
    }
}