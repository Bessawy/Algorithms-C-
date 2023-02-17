public class BinaryTrees
{
    public class TreeNode<T> {
        public T val;
        public TreeNode<T> left;
        public TreeNode<T> right;
        public TreeNode(T val, TreeNode<T> left=null, TreeNode<T> right=null) {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public static void Inorder()
    {
        TreeNode<char> root = new TreeNode<char>('F');
        root.left = new TreeNode<char>('B');
        root.right = new TreeNode<char>('G');
        root.left.left = new TreeNode<char>('A');
        root.left.right = new TreeNode<char>('D');
        root.left.right.left = new TreeNode<char>('C');
        root.left.right.right = new TreeNode<char>('E');

        void Dfs(TreeNode<char> tree)
        {
            if(tree == null)
                return;
            
            Dfs(tree.left);
            Console.Write(tree.val + "-");

            Dfs(tree.right);
        }

        Dfs(root);
    }






}