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
           

            A b=new B();
            b.one(2);
        }
    }
    class A
    {
        
        public void one()
        {
            Console.WriteLine("one");
        }
        public virtual void one(int a)
        {
            
            Console.WriteLine("overloading  trewjq abinesh j ");
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
