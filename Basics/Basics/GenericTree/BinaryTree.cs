using System;

namespace Basics.GenericTree
{
    public class BinaryTree<T>
    {
        private BinaryTreeNode<T> _root;
        private Func<T, T, bool> _comparator;
        public BinaryTree(Func<T, T, bool> comparator)
        {
            _root = null;
            _comparator = comparator;
        }

        public void InsertValue(T value)
        {
            if (_root == null)
            {
                _root = new BinaryTreeNode<T>(value, _comparator);
            }
            else
            {
                _root.InsertChild(value);
            }
        }

        public void Print()
        {
            _root.Print();
        }

        public override string ToString()
        {
            return _root.ToString();
        }
    }
}
