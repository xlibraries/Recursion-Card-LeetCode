/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    List<TreeNode>[,] dump;
    List<TreeNode> answers = new List<TreeNode>();
    public IList<TreeNode> GenerateTrees(int n) {
        if(n == 0)
            return new List<TreeNode>();
        dump = new List<TreeNode>[n+1, n+1];
        return gen(1, n);
    }
    
    public List<TreeNode> gen(int start, int end)
    {
        List<TreeNode> result = new List<TreeNode>();
        
        if(start > end)
        {
            result.Add(null);
            return result;
        }
        else if(start == end)
        {
            result.Add(new TreeNode(start));
            return result;
        }
        else
        {
            if(dump[start, end] != null)
                return dump[start, end];
            for(int i = start; i <= end; i++)
            {
                List<TreeNode> leftChoices = gen(start, i-1);
                List<TreeNode> rightChoices = gen(i+1, end);
                for(int j = 0; j < leftChoices.Count; j++)
                {
                    for(int k = 0; k < rightChoices.Count; k++)
                    {
                        TreeNode root = new TreeNode(i);
                        root.left = leftChoices[j];
                        root.right = rightChoices[k];
                        result.Add(root);
                    }
                }
            }
        }
        
        dump[start, end] = result;
        return result;
    }
    
    
}
