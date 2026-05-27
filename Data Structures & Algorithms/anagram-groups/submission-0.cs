public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<string>> map = new Dictionary<string,List<string>>();
        foreach(string word in strs ){
            int[] count = new int[26];
            foreach(char val in word){
                count[val-'a']++;
            }
            StringBuilder sb = new StringBuilder();

            foreach(int num in count){
                sb.Append(num).Append('#');
            }
            String key = sb.ToString();

            if(!map.ContainsKey(key)){
                map[key] = new List<string>();
            }
            map[key].Add(word);
        }

        return new List<List<string>>(map.Values);
        
    }
}
