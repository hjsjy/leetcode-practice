/*
 * @lc app=leetcode.cn id=101 lang=csharp
 *
 * [101] 对称二叉树
 */

// @lc code=start
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
    public bool IsSymmetric(TreeNode root) {
       return Check(root,root);
    }

    public bool Check(TreeNode root1,TreeNode root2){
            if(root1 == null&&root2 == null){
                return true;
            }else if(root1 == null || root2 == null ||root1.val != root2.val){
                return false;
            }else{
                return Check(root1.left,root2.right) &&Check(root1.right,root2.left);
            }
    }
}
// @lc code=end

