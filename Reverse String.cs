public class Solution 
{
    public void ReverseString(char[] s) 
    {
        int index = 0;
        Helper(s, index);
        //return s;
    }
    public void Helper(char[] s, int index)
    {
        if(index == s.Length / 2)
        {
            return ;
        }
        char temp = s[s.Length - 1 - index];
        s[s.Length - 1 - index] = s[index];
        s[index] = temp;
        Helper(s, index + 1);
        //return s;
    }
}
