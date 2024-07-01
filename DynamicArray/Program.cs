using DynamicArray;

internal class Program
{
    private static void Main(string[] args)
    {
        Dynamicarray a = new Dynamicarray();
        int x,container,index;
        do 
        {
            showOptions();
            Console.WriteLine("Choose option");
            x = Convert.ToInt32(Console.ReadLine());
            switch (x) 
            {
                case 0:
                    Console.WriteLine("End program");
                    break;
                case 1:
                    if (a.IsFull())
                    {
                        Console.WriteLine("Array is Full You can use option 9");
                    }
                    else
                    {
                        Console.WriteLine("Array not full");
                    }
                    break;
                case 2:
                    if (a.IsEmpty())
                    {
                        Console.WriteLine("Array is Empty");
                    }
                    else
                    {
                        Console.WriteLine("Array has elements");
                    }
                    break;
                case 3:
                    Console.WriteLine("Enter value : ");
                    container = Convert.ToInt32(Console.ReadLine());
                    a.Append(container);
                    break;
                case 4:
                    Console.WriteLine("Enter value : ");
                    container = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter position");
                    index = Convert.ToInt32(Console.ReadLine());
                    index--;
                    a.insert(container,index);
                    break;
                case 5:
                    a.sortArray();
                    Console.WriteLine("Array is sorted");
                    break;
                case 6:
                    Console.WriteLine("Enter value to find it");
                    container = Convert.ToInt32(Console.ReadLine());
                    a.Search(container);
                    break;
                case 7:
                    Console.WriteLine("you remove the last element");
                    a.Remove();
                    break;
                case 8:
                    Console.WriteLine("Enter value you want delete it");
                    container = Convert.ToInt32(Console.ReadLine());
                    a.Delete(container);
                    break;
                case 9:
                    Console.WriteLine("Enter size : ");
                    container = Convert.ToInt32(Console.ReadLine());
                    a.IncreaseSize(container);
                    break;
                case 10:
                    Console.WriteLine("__________________________");
                    a.printArray();
                    Console.WriteLine("__________________________");
                    break ;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        } while (x!=0);
    }
    public static void showOptions() 
    {
        Console.WriteLine("_______________________________");
        Console.WriteLine("1-IsFull");
        Console.WriteLine("2-IsEmpty");
        Console.WriteLine("3-Append");
        Console.WriteLine("4-Insert");
        Console.WriteLine("5-Sort");
        Console.WriteLine("6-Search");
        Console.WriteLine("7-Remove");
        Console.WriteLine("8-Delete");
        Console.WriteLine("9-Increase size");
        Console.WriteLine("10-Print Array");
        Console.WriteLine("0-Exit");
        Console.WriteLine("_______________________________");
    }
}
