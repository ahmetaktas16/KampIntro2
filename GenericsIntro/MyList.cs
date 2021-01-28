using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //constructor

        public MyList()
        {
            items = new T[0];
        }

        public void Add(T item)
        {
            T[] tempArray = items; //geçiciyi tamamen önceki değerleri korumak için tutuyorum.
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++) //emaneten verdiğim verileri geri versene.tempArray'in
                                                       //bütün elemanlarını items'a geri atayacağım.
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }
            







    }
}
