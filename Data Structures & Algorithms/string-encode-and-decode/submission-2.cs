public class Solution {

    public string Encode(IList<string> strs)
    {
        var sb = new StringBuilder();
        foreach(var str in strs) {
            sb.Append(str.Length);
            sb.Append('#');
            sb.Append(str);
        }
        return sb.ToString();
    }

    public List<string> Decode(string s)
    {
        var result = new List<string>();
        var i = 0;
        while(i < s.Length) {
            var j = i;
            
            // Find separator
            while(s[j] != '#'){
                j++;
            }
            
            // Parse length
            var length = int.Parse(s.Substring(i, j - i));

            // Get substring
            var subStr = s.Substring(j + 1, length);
            result.Add(subStr);
            
            i = j + 1 + length;
        }
        return result;
    }
}
