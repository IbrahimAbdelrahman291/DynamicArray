using System;


namespace DynamicArray
{
    internal class Dynamicarray
    {
        int size;
        int length;
        int[] Array;

        public Dynamicarray()
        {
            size = 10;
            length = 0;
            Array = new int[size];
        }

        //check conditions
        public bool IsFull()
        {
            return (length + 1 <= size) ? false : true;
        }
        public bool IsEmpty()
        {
            return (length == 0) ? true : false;
        }
        // Fill array 
        public void Append(int value)
        {
            if (IsFull())
            {
                Console.WriteLine("Array is Full");
            }
            else
            {
                Array[length] = (Array[length] != 0) ? Array[length] : value;
                length++;
            }
        }
        public void insert(int value, int index)
        {
            if (IsFull())
            {
                Console.WriteLine("Array is Full");
                return;
            }
            else if (index >= size)
            {
                Console.WriteLine("OUT OF RANGE!");
                return;
            }
            else if(index<0)
            {
                Console.WriteLine("OUT OF RANGE!");
                return;
            }
            else
            {
                if (length <= index)
                {
                    Array[index] = value;
                }
                else
                {
                    for (int i = length; i >= index; i--)
                    {
                        Array[i + 1] = Array[i];
                    }
                    Array[index] = value;
                    length++;
                }
            }
        }
        //Sorting 
        public void sortArray()
        {
            int container = 0;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length - 1; j++)
                {
                    if (Array[j] > Array[j + 1])
                    {
                        container = Array[j + 1];
                        Array[j + 1] = Array[j];
                        Array[j] = container;
                    }
                }
            }
        }
        //Searching
        public int Search(int value)
        {
            if (IsEmpty())
            {
                return -1;
            }
            else
            {
                sortArray();
                int low = 0;
                int high = length;
                while (low <= high)
                {
                    int mid = (low + high) / 2;
                    if (Array[mid] == value)
                    {
                        return mid;
                    }
                    else if (value < Array[mid])
                    {
                        high = mid - 1;
                    }
                    else
                    {
                        low = mid + 1;
                    }
                }
                return -1;
            }
        }
        //emptying
        public void Remove()
        {
            Array[length - 1] = 0;
            length--;

        }
        public void Delete(int value)
        {
            int index = Search(value);
            if (index == -1)
            {
                Console.WriteLine("Not Found!");
                return;
            }
            else if (index != -1)
            {
                Array[index] = 0;
                for (int i = index; i < length; i++)
                {
                    Array[i] = Array[i + 1];
                }
                length--;
            }
        }
        //increasing size
        public void IncreaseSize(int NewSize)
        {
            int[] newArray = new int[size + NewSize];
            for (int i = 0; i < length; i++)
            {
                newArray[i] = Array[i];
            }
            Array = newArray;
            size += NewSize;
        }
        //Show Data
        public void printArray()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Empty");
            }
            else
            {
                int count = 0;
                while (count+1 <= size) 
                {
                    Console.WriteLine($"Index {count}:{Array[count]}");
                    count++;
                }
            }
        }
    }
}
