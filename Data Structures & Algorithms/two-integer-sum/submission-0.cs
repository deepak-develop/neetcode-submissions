public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> map = new Dictionary<int,int>();
        for(int i= 0;i<nums.Length;i++){
            int val = target - nums[i];
            if(map.ContainsKey(val)){
                int index1 = map[val];
                int index2 = i;
                if(index1>index2){
                    return new int[] {index2, index1};
                }
                return new int[] {index1, index2};             
            }
            map[nums[i]] = i;
        }
        return new int[] { -1, -1 };
    }
}
