using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T>
    {
        private T[] items = new T[4];
        //Array that will hold values for our CustomList. Starts with size 4, then doubles each time
        //count is equal to capacity.
        private int capacity=4;
        private int count;

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
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }

        public void Add(T item)
        {
            //Adding an item to the list requires that the capacity be less than the count.
            //If the capacity is equal to the count, a new array must be created before adding the item.
            //This new array will have double the capacity of the previous array.
            //When an item is added, the index value should be equal to the count.

        }

        public void Remove(T item)
        {
            //Removing an item is a more complicated, because the indices for all items
            //that follow must be adjusted. Similarly to the Add method, we will take capacity
            //into account. This is not completely necessary, but is good for consistency.
            //If capacity is greater than 4 and if the count (after removal) is 1/2 the capacity, then
            //the new array should be 1/2 the current size.
        }

        public void Zip(List<T> list)
        {

        }


    }
}
