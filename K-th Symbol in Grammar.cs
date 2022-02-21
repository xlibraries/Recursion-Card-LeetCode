public class Solution 
{
   public int KthGrammar(int N, int K)
    {
	    N = N - 1;
    	K = K - 1;
	    return F(N, K);
    }

    public int F(int n, int k)
    {
	    if (n == 0) return 0;
    	if (k % 2 == 0)
	    {
		    return F(n - 1, k / 2);
	    }
	    return F(n - 1, k / 2) == 1 ? 0 : 1;
    }
}
