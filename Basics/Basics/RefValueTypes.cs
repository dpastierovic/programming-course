using System;
using System.Collections.Generic;
using System.Text;

namespace Basics
{
    static class RefValueTypes
    {
        public static void ValueType()
        {
            int a = 10;
            int b = 2;
            Console.WriteLine($"a: {a}, b: {b} {Object.ReferenceEquals(a, b)}");
            a = b;
            Console.WriteLine($"a: {a}, b: {b} {Object.ReferenceEquals(a, b)}");
            b = 3;
            Console.WriteLine($"a: {a}, b: {b} {Object.ReferenceEquals(a, b)}");
        }

        public static void ReferenceType()
        {
            var obj1 = new CustomObject(10, 2);
            var obj2 = new CustomObject(10, 2);
            Console.WriteLine($"OBJ1 [a: {obj1.A}, b: {obj1.B}], OBJ2 [a: {obj2.A}, b: {obj2.B}] {Object.ReferenceEquals(obj1, obj2)}");
            obj1.A = 5;
            Console.WriteLine($"OBJ1 [a: {obj1.A}, b: {obj1.B}], OBJ2 [a: {obj2.A}, b: {obj2.B}] {Object.ReferenceEquals(obj1, obj2)}");
            obj2 = obj1;
            Console.WriteLine($"OBJ1 [a: {obj1.A}, b: {obj1.B}], OBJ2 [a: {obj2.A}, b: {obj2.B}] {Object.ReferenceEquals(obj1, obj2)}");
            obj1.A = 7;
            Console.WriteLine($"OBJ1 [a: {obj1.A}, b: {obj1.B}], OBJ2 [a: {obj2.A}, b: {obj2.B}] {Object.ReferenceEquals(obj1, obj2)}");
        }

        public static void StringType()
        {
            var name = "Vilajdies";
            var surname = "Brezina";
            Console.WriteLine($"{name} {surname} { Object.ReferenceEquals(name, surname)}");
            name = "Dominik";
            Console.WriteLine($"{name} {surname} { Object.ReferenceEquals(name, surname)}");
            surname = name;
            Console.WriteLine($"{name} {surname} { Object.ReferenceEquals(name, surname)}");
            name = "Vlado";
            Console.WriteLine($"{name} {surname} { Object.ReferenceEquals(name, surname)}");

            Console.WriteLine(name == "Vlado");
        }
    }

    public class CustomObject
    {
        public int A { get; set; }
        public int B { get; set; }

        public CustomObject(int a, int b)
        {
            A = a;
            B = b;
        }
    }
}
