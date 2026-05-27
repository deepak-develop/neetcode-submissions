public class Solution {
    public int[] TwoSum(int[] numbers, int target) {

        int left = 0;
        int right = numbers.Length - 1;
        while(left < right){
            int currentSum = numbers[left] + numbers[right];
            //problem requires 1 indexd output
            if(currentSum == target){
                return new int[]{left +1,right +1};
            }
            if(currentSum < target){
                //sum is too small , move left pointer to increse sum
                left++;
            }
            else{
                //sum is too large move right pointer to decrease sum
                right--;
            }
        }
        return new int[0];
        
    }
}
