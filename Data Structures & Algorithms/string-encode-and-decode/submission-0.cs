public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder sb = new StringBuilder();
         foreach(string s in strs){
            sb.Append(s.Length).Append('#').Append(s);

         }
         return sb.ToString();
        
    }

    public List<string> Decode(string s) {
        List<String> result = new List<String>();
        int i = 0;
        while(i < s.Length){
            int j = i;
            while(s[j] != '#'){
                j++;
            }  
            int length = int.Parse(s.Substring(i,j-i));

        String word = s.Substring(j+1,length);

        result.Add(word);

        i= j+1+length;
        }
        return result;
        

   }
   
}
