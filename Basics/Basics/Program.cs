using System;
using System.Collections.Generic;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var square = new Square(5);
            Console.WriteLine(square.GetArea());
            var x = MathExtensions.Power(16);
            Console.WriteLine(square.ToString());

            var rect = new Rectangle(3, 4);
            rect.GetArea();
        }
    }

    public class Square
    {
        protected int _a;

        public int A 
        {
            get
            {
                return _a;
            }
        }

        public Square(int a)
        {
            _a = a;
        }

        public virtual int GetArea()
        {
            return MathExtensions.Power(_a);
        }

        public override string ToString()
        {
            return $"Square area is: {GetArea()} Type is: {base.ToString()}";
        }
    }

    public class Rectangle : Square
    {
        private int _b;
        public Rectangle(int a, int b)
            : base(a)
        {
            _b = b;
        }

        public override int GetArea()
        {
            return _a * _b;
        }
    }

    public static class MathExtensions
    {
        public static int Power(int number)
        {
            return number * number;
        }

        public static int Absolute(int number)
        {
            if (number < 0) return -number;
            return number;
        }
    }
}
