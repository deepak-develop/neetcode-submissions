public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        //count freq
        Dictionary<int,int> freq = new Dictionary<int,int>();

        foreach(int val in nums){
            if(!freq.ContainsKey(val)){
                freq[val] = 0;

            }
            freq[val]++;
        }
        //Bucket
        List<int>[] bucket = new List<int>[nums.Length +1];
        foreach(var entry in freq){
            var f = entry.Value;
            if(bucket[f] == null){
                bucket[f] = new List<int>();
            }
            bucket[f].Add(entry.Key);
        }

        //Result
        List<int> res = new List<int>();
        for(int i = bucket.Length -1;i>=0 && res.Count < k;i--){
            if(bucket[i] != null){
                res.AddRange(bucket[i]);
            }
        }

        return res.GetRange(0,k).ToArray();
        
    }
}
