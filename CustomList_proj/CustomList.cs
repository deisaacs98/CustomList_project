using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList_proj
{

    public class CustomList<T> : IEnumerable where T:IComparable
    {

        private T[] items = new T[4];
        //Array that will hold values for our CustomList. Starts with size 4, then grows as necessary.
        //Will also need a temporary array for when we increase the capacity.
        private T[] tempItems;
        private int capacity = 4;
        private int count;

        public T this[int index]
        {
            get
            {
                return items[index];
            }
            set
            {
                items[index] = value;
            }
        }

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
            //Adding an item to the list requires that the capacity be less than or equal to the count.
            //If the capacity is larger than the count, a new array must be created before adding the item.
            //This new array will have the capacity equal to the count.
            //When an item is added, the index value should be equal to the count.
            count++;
            if (count > capacity)
            {
                tempItems = new T[count];
                for (int i = 0; i < capacity; i++)
                {
                    tempItems[i] = items[i];
                }
                capacity = count;
                tempItems[capacity - 1] = item;
                items = tempItems;
            }
            else
            {
                items[count - 1] = item;
            }
        }

        public void Remove(T item)
        {
            //Removing an item is a more complicated, because the indices for all items
            //that follow must be adjusted. Similarly to the Add method, we will take capacity
            //into account. This is not completely necessary, but is good for consistency.
            //

            bool foundMatch=false;
            bool removedItem = false;
            foreach (T thing in items)
            {
                if(thing.Equals(item))
                {
                    foundMatch = true;
                    break;
                }
            }
            if (foundMatch)
            {
                count--;
                tempItems = new T[count];
                for (int i = 0; i <= count; i++)
                {
                    if (items[i].Equals(item) && (removedItem == false))
                    {
                        removedItem = true;
                    }
                    else if (removedItem == true)
                    {
                        tempItems[i - 1] = items[i];
                    }
                    else
                    {
                        tempItems[i] = items[i];
                    }
                }
                items = tempItems;
            }
        }
        public static CustomList<T> operator +(CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> list = new CustomList<T>();
            foreach (T item in list1)
            {
                list.Add(item);
            }
            foreach (T item in list2)
            {
                list.Add(item);
            }
            return list;
        }
        public static CustomList<T> operator -(CustomList<T> list1, CustomList<T> list2)
        {
            foreach (T item1 in list1)
            {
                foreach (T item2 in list2)
                {
                    list1.Remove(item2);
                }
            }
            return list1;
        }
        public void Zip(CustomList<T> list)
        {
            capacity = list.Capacity + capacity;
            T[] result = new T[capacity];
            
            for (int i = 0; i < count; i++)
            {
                if(items[i]!=null&&list[i]!=null)
                {
                    result[2 * i] = items[i];
                    result[2 * i + 1] = list[i];
                }
                else if (list[i] != null)
                {
                    result[2 * i] = list[i];
                    result[2 * i + 1] = list[i];
                }
                else
                {
                    result[2 * i] = items[i];
                    result[2 * i + 1] = items[i];
                }
            }
            count += list.Count;
            items = result;

        }

        public override string ToString()
        {
            string printList="";
            for(int i=0;i<count;i++)
            {
               
                string name = items[i].ToString();
                name += " ";
                printList += name;

            }
            return printList;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }

        public int CompareTo(T other)
        {
            return other.CompareTo(this);
        }
        //Since Array.Sort() uses the QuickSort algorithm, let's just call this method QuickSort().
        //This algorithm works by picking a value in the list as a pivot. This will split the
        //list into two parts, values above the pivot and values below the pivot. The process is
        //then repeated until the list is in order.
        //
        //The example below should demonstrate what we're trying to do here. The first pivot point
        //will be the last item in the list:
        //
        //[2, 6, 1, 5, 7, 3, 4]                           We need to create two new arrays 
        //[2,1,3] 4 [6,5,7]                               by comparing each value to the pivot.  
        //[2,1] 3 4 [6,5] 7                               And then repeat...
        //1 2 3 4 5 6 7
        public void QuickSort(T[] list, int first, int last)
        {
            if(first<last)
            {
                int part = Partition(list, first, last-1);
                tempItems[part] = list[part];
                for(int i=0)
                QuickSort(list, first, part - 1);
                QuickSort(list, part + 1, last);
            }
        }

        public static int Partition(T[] list, int first, int last)
        {
            T pivot = list[last];
            int firstInd = first-1;
            int output = 0;
            for(int i = firstInd;i<last;i++)
            {
                int comp = list[i].CompareTo(pivot);
                if(comp<0)
                {
                    output++;
                }
            }
            return output;
        }

        public void Sort()
        {
            QuickSort(items, 1, count);
            items = tempItems;
        }
    }
}

