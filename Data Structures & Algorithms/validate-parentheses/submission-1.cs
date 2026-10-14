public class Solution
{
    public bool IsValid(string s)
    {
        var charArray = s.ToCharArray();
        var charStack = new Stack<char>();
        var dictMatches = new Dictionary<char, char>()
        {
            { ')', '(' },
            { ']', '[' },
            { '}', '{' },
        };

        foreach(var character in s)
        {   
            if(charStack.Any())
            {
                var top = charStack.Peek();
                if (dictMatches.TryGetValue(character, out var value))
                {
                    if (value == top)
                    {
                        charStack.Pop();
                        continue;
                    }
                    
                }
            }
            charStack.Push(character);
        }

        return !charStack.Any();
    }
}