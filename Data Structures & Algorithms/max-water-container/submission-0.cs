public class Solution {
    public int MaxArea(int[] heights) {
        int left = 0;
        int right = heights.Length -1;
        int maxArea = 0;
        while(left < right){
            int h = Math.Min(heights[left],heights[right]);
            int width = right - left;
            int area = h * width;
            maxArea = Math.Max(maxArea,area);

            //move the pointer to shorter line
            if(heights[left] < heights[right]){
                left ++;
            }
            else{
                right--;
            }
        }
        return maxArea;

    }
}
/* formula for area
{Area}=\min (height[left],height[right])\times (right-left)

*/