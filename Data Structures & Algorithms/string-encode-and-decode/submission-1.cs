public class Solution {

    public string Encode(IList<string> strs)
    {
        string encodedStr = null;
        foreach (var str in strs)
        {
            if(encodedStr == null)
            {
                encodedStr = str;
            }
            else
            {
                encodedStr = string.Concat(encodedStr, "💀", str);
            }
        }
        return encodedStr;
    }

    public List<string> Decode(string s)
    {
        if(s == null)
        {
            return new List<string>();
        }
        var decoded = s.Split("💀").ToList();
        return decoded;
    }
}
