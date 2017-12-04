using System;
using System.Collections.Generic;

namespace CovarianceWithGenericInterfaceEx
{
    class Parent
    {
        public virtual void ShowMe()
        {
            Console.WriteLine(" I am from Parent, my hash code is :" + GetHashCode());
        }
    }
    class Child : Parent
    {
        public override void ShowMe()
        {
            Console.WriteLine(" I am from Child, my hash code is:" + GetHashCode());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            //Covariance Example

            Console.WriteLine("***Covariance with Generic Interface Example***\n");
            Console.WriteLine("***IEnumerable<T> is covariant");
            //Some Parent objects
            Parent pob1 = new Parent();
            Parent pob2 = new Parent();
            //Some Child objects
            Child cob1 = new Child();
            Child cob2 = new Child();
            //Creating a child List
            List<Child> childList = new List<Child>();
            childList.Add(cob1);
            childList.Add(cob2);
            IEnumerable<Child> childEnumerable = childList;
            // An object which was instantiated with a more derived type argument (Child) 
            //is assigned to an object instantiated with a less derived type argument(Parent).
            //Assignment compatibility is preserved here. 
            IEnumerable<Parent> parentEnumerable = childEnumerable;
            foreach (Parent p in parentEnumerable)
            {
                p.ShowMe();
            }
          Console.ReadKey();
        }
    }

}
