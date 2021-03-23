using System;
namespace CountWord
{
    public class Tree
    {
        private string word;
        private int count;
        private Tree left, right;
        public string Word
        {
            get { return word; }
            set { word = value; }
        }
        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        public Tree Left
        {
            get { return left; }
            set { left = value; }
        }
        public Tree Right
        {
            get { return right; }
            set { right = value; }
        }
    }
}
