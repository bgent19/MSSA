Tree bst = ArrayToBST([4, 2, 7, 1, 3]);

TreeNode search = SearchBST(bst.root, 2);

Console.WriteLine(search.val); // 2
try
{
    Console.WriteLine(SearchBST(bst.root, 5).val); // null
}
catch(NullReferenceException _)
{
    Console.WriteLine("value not found");
}

static TreeNode SearchBST(TreeNode root, int val)
{
    if(root==null)
    {
        return null;
    }

    if(root.val == val)
    {
        return root;
    }

    return val < root.val ? SearchBST(root.left, val) : SearchBST(root.left, val);
}

static Tree ArrayToBST(int[] a)
{
    Tree result = new();
    Queue<TreeNode> trav = [];

    result.root = new TreeNode(a[0]);
    trav.Enqueue(result.root);

    int i = 1;

    while(trav.Count() > 0 && i < a.Length)
    {
        TreeNode cur = trav.Dequeue();

        cur.left = new TreeNode(a[i++]);
        trav.Enqueue(cur.left);

        if(i < a.Length)
        {
            cur.right = new TreeNode(a[i++]);
            trav.Enqueue(cur.right);
        }
    }


    return result;
}

public class Tree
{
    public TreeNode root;
}

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
 }


