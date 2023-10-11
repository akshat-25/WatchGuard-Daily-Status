using System;


namespace ToDoList
{
    class Program
    {
        enum UserChoice
        {
            AddTask = 1,
            RemoveTask,
            ViewList,
            Exit
        }
        static void Main(string[] args)
        {
            var list = new List<string>();

            while(true)
            {
                Console.WriteLine("Choose from the following options:");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. Remove Task");
                Console.WriteLine("3. View To-Do List");
                Console.WriteLine("4. Exit");

                int choice = int.Parse(Console.ReadLine());

                if(choice == (int)UserChoice.AddTask) {
                    Console.WriteLine("Enter task:");
                    string task = Console.ReadLine();
                    list.Add(task);
                    Console.Clear();
                    Console.WriteLine("Task added Successfully");

                }
                else if(choice == (int)UserChoice.RemoveTask)
                {
                    Console.WriteLine("Enter the task number to be deleted");
                    int input = int.Parse(Console.ReadLine());
                    
                        list.Remove(list[input]);
                    
                   
                    Console.Clear();
                    Console.WriteLine("Task deleted succesfully");

                }
                else if(choice == (int)UserChoice.ViewList)
                {
                    int i = 1;
                    foreach (var item in list)
                    {
                        Console.WriteLine($"{i}.) " + item);
                        i++;
                    }
                }
                else if(choice == (int)UserChoice.Exit)
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Enter a valid choice");
                }

            }
        }
    }
}