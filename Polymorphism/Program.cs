using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A a = new A();
            //a.Add(50,60);

            A b=new B();
            b.one(2);
        }
    }
    class A
    {
        //public void Add()
        //{
        //    int a = 10;
        //    int b = 20;
        //    Console.WriteLine(a+b);
        //}
        //public void Add(int a)
        //{
        //    int b = 20;
        //    Console.WriteLine(a + b);
        //}
        //public void Add(int a,int b)
        //{
        //    Console.WriteLine(a + b);
        //}
        public void one()
        {
            Console.WriteLine("one");
        }
        public virtual void one(int a)
        {
            
            Console.WriteLine("overloading         ggh ");
        }

    }
    class B : A
    {
        public override void one(int a)
        {
            base.one(a);
            Console.WriteLine("overrideing");
        }
    }
}
