using System;

namespace CountWord
{
    class BST
    {        
        public Tree EndLeftNode(Tree root)
        {
            Tree p = root;
            while (p.Left != null) p = p.Left;
            return p;
        }
        public Tree CreateNode(string Word, int Count)
        {
            Tree p = new Tree();
            if (p == null)
            {                
                return null;
            }
            p.Left = null;
            p.Right = null;
            p.Word = String.Copy(Word);
            p.Count = Count;
            return p;
        }
        public Tree InsertNode(Tree root, string Word, int Count)
        {
            if (root == null) root = CreateNode(Word, Count);
            else if (String.Compare(root.Word, Word) > 0)
                root.Left = InsertNode(root.Left, Word, Count);
            else
                root.Right = InsertNode(root.Right, Word, Count);
            return root;
        }
        public Tree Search(Tree root, string Word)
        {
            if (root == null) return null;
            Tree p = root;
            while (p != null)
            {
                if (String.Compare(p.Word, Word) == 0) return p;
                else if (String.Compare(p.Word, Word) > 0) p = p.Left;
                else p = p.Right;
            }
            return p;
        }
        public Tree DeleteNode(Tree root, string Word)
        {
            if (root == null) return root;
            if (String.Compare(root.Word, Word) > 0)
                root.Left = DeleteNode(root.Left, Word);

            else if (String.Compare(root.Word, Word) < 0)
                root.Right = DeleteNode(root.Right, Word);
            else
            {
                if (root.Left == null)
                {
                    Tree p = root.Right;
                    root = null;
                    return p;
                }
                else if (root.Right == null)
                {
                    Tree p = root.Left;
                    root = null;
                    return p;
                }
                else
                {
                    Tree p = EndLeftNode(root.Right);
                    root.Word = String.Copy(p.Word);
                    root.Count = p.Count;
                    root.Right = DeleteNode(root.Right, p.Word);
                }
            }
            return root;
        }
    }
}
