public class Solution {
    public bool IsPalindrome(string s) {
       int left = 0;
       int right = s.Length - 1;

       while(left < right){
        //skip non-alphanumeric char from left
        while(left < right && !char.IsLetterOrDigit(s[left])){
            left++;
        }
        //skip non-alphanumeric char from right
        while(left < right && !char.IsLetterOrDigit(s[right])){
            right--;
        }

        //Compare characters case-insensitivity
        if(char.ToLower(s[left]) != char.ToLower(s[right])){
            return false;
        }

        left++;
        right--;
       }

       return true;
        
        
    }
}
