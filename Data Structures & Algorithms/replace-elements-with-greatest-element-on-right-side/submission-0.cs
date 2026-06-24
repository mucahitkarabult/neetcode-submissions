public class Solution {
    public int[] ReplaceElements(int[] arr) {
        int maxsofar=arr[arr.Length-1];
        arr[arr.Length-1]=-1;
        for(int num =arr.Length-2;num>=0;num--){
            int temp= arr[num];
            arr[num]=maxsofar;
            if(temp>maxsofar)
                maxsofar=temp;
            
        }
        return arr;
    }
}