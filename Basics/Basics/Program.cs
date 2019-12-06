using System;
using System.Collections.Generic;
using System.Linq;

namespace Basics
{
    class Program
    {
        delegate bool IsEven(int a);

        static void Main(string[] args)
        {
            var text = SomeText.LoremIpsum();
            text = text.Replace('a', 'A');
            Console.WriteLine(text);

            Console.WriteLine();

            text = SomeText.LoremIpsum();

            var reversedText = text.Reverse();

            Console.WriteLine(reversedText);

            var removedUseless = text.RemoveUseless();

            Console.WriteLine(removedUseless);

            CustomAlmonds();

            var number = 5;
            var result = number.IsEven();
            Console.WriteLine(result);

            IsEven function = delegate (int a) { return a % 2 == 0; };
            function = (a) => { return a % 2 == 0; };

            text = text.Replace(",", "").Replace(".", "");
            var words = text.Split(' ').ToList();

            words = words.Where(v => v.StartsWith('l') || v.StartsWith('L')).ToList();

            words = (from w in words where w.StartsWith('l') || w.StartsWith('L') select w).ToList();

            Console.WriteLine("----------------------------Lorem Ipsum words----------------------------");

            foreach(var word in words)
            {
                Console.WriteLine(word);
            }

            var loremCount = 0;
            loremCount = words.Count(v => v == "Lorem" || v == "lorem");
            Console.WriteLine($"Number of Lorem is {loremCount}");
        }

        public static int Count(List<string> list, Func<string, bool> predicate)
        {
            var count = 0;

            foreach(var word in list)
            {
                if (predicate(word)) count++;
            }

            return count;
        }


        static void FirstLession()
        {
            Console.WriteLine("Hello World!");

            var square = new Square(5);
            Console.WriteLine(square.GetArea());
            var x = MathExtensions.Power(16);
            Console.WriteLine(square.ToString());

            var rect = new Rectangle(3, 4);
            rect.GetArea();

            RefValueTypes.ValueType();
            RefValueTypes.ReferenceType();
            RefValueTypes.StringType();
        }

        static void CustomAlmonds()
        {
            Almond myAlmond = new Almond(15, 5);
            Almond yourAlmond = new Almond(5, 20);
            /*Console.WriteLine(myAlmond.isAlmond());
            Console.WriteLine(yourAlmond.isAlmond());*/

            
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
