public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char, int> charMap = new Dictionary<char, int>();
        int maxLength = 0;
        int l = 0;
        for (int r = 0; r < s.Length; r++) {
            char currentChar = s[r];
            if (charMap.ContainsKey(currentChar)) {
                l = Math.Max(l, charMap[currentChar] + 1);
            }
            charMap[currentChar] = r;

            int currentWindowLength = r - l + 1;
            maxLength = Math.Max(maxLength, currentWindowLength);
        }
        return maxLength;
    }
}
