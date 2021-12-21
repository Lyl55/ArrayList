using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    public class ArrayList
    {
        private object[] arr;
        private int count = 0;

        public int Count
        {
            get
            {
                return count;
            }
        }

        public int Capacity
        {
            get
            {
                return arr.Length;
            }
        }

        public ArrayList()
        {
            arr = new object[1];
        }

        public void Add(object x)
        {
            if (count == arr.Length)
            {
                object[] arr2 = new object[arr.Length * 2];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr2[i] = arr[i];

                }

                arr = arr2;

            }
            arr[count++] = x;
        }


        public void Show()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
