/*
    n = 0; result = 0; //0
    n = 1; result = 1; // 1,0
    n = 2; result = 2; // 1,1 ; 2,0
    n = 3; result = 3; // 1,1,1 ; 1,2; 2,1
    n = 4; result = 5; // 1,1,1,1 ; 1,1,2; 1,2,1 ; 2,1,1; 2,2
    n = 5; result = 8; //1,1,1,1,1; 1,1,1,2; 1,1,2,1 ; 1,2,1,1; 2,1,1,1; 1,2,2; 2,1,2; 2,2,1
    
    result += result( -1) + result( -2)
*/
public class Solution 
{
    int[] result = new int[2] {0, 1};
    int count = 0;
    public int ClimbStairs(int n) 
    {
        if(n == 1)
        {
            return result[1] + result[0];
        }
        int temp = result[0];
        result[0] = result[1];
        result[1] = result[1] + temp;
        ClimbStairs(n - 1);
        return result[1] + result[0];
    }
}
