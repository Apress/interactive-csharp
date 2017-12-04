using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class MyStoreHouse<T>
    {
        T[] myStore = new T[3];
        int position = 0;
        public MyStoreHouse()
        {
            for (int i = 0; i < myStore.Length; i++)
            {
                myStore[i] = default(T);
            }
        }
        public void AddToStore(T value)
        {
            if (position < myStore.Length)
            {
                myStore[position] = value;
                position++;
            }
            else
            {
                Console.WriteLine("Store is full already");
            }
        }

        public void RetrieveFromStore()
        {
            foreach (T t in myStore)
            {
                Console.WriteLine(t);
            }
            //Or Use this block
            //for (int i = 0; i < myStore.Length; i++)
            //{
            //    Console.WriteLine(myStore[i]);
            //}

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Use case-default keyword in generic programming:***");
            Console.WriteLine("***\nCreating an Integer store:***");
            MyStoreHouse<int> intStore = new MyStoreHouse<int>();
            intStore.AddToStore(45);
            intStore.AddToStore(75);
            Console.WriteLine("***Integer store at this moment:***");
            intStore.RetrieveFromStore();

            Console.WriteLine("***\nCreating an String store:***");
            MyStoreHouse<string> strStore = new MyStoreHouse<string>();
            strStore.AddToStore("abc");
            strStore.AddToStore("def");
            strStore.AddToStore("ghi");
            strStore.AddToStore("jkl");//Store is full already
            Console.WriteLine("***String store at this moment:***");
            strStore.RetrieveFromStore();
            Console.ReadKey();
        }
    }

}
