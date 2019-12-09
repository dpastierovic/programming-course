using System;

namespace Basics.GenericTree
{
    public class BinaryTreeNode<T>
    {
        private Func<T, T, bool> _comparator;

        public T Value { get; set; }
        public BinaryTreeNode<T> Left { get; private set; }
        public BinaryTreeNode<T> Right { get; private set; }

        public BinaryTreeNode(T value, Func<T, T, bool> comparator)
        {
            Value = value;
            _comparator = comparator;
        }

        public void InsertChild(T value)
        {
            if (_comparator(Value, value))
            {
                if (Left == null)
                {
                    Left = new BinaryTreeNode<T>(value, _comparator);
                }
                else
                {
                    Left.InsertChild(value);
                }
            }
            else
            {
                if (Right == null)
                {
                    Right = new BinaryTreeNode<T>(value, _comparator);
                }
                else
                {
                    Right.InsertChild(value);
                }
            }
        }

        public void Print()
        {
            Left?.Print();
            Console.WriteLine($"{Value}");
            Right?.Print();
        }

        public override string ToString()
        {
            return $"{Value.ToString()} {Left?.ToString()} {Right?.ToString()} ";
        }
    }
}
