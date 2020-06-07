using System;
using System.Collections.Generic;
using System.Text;

namespace LittleProject.WarungNasi
{
    class Program
    {
        static void Main()
        {
            // untuk menyimpan data
            List<Todo> todoList = new List<Todo>();
            string pilihan;
            do
            {
                Console.WriteLine("\t\t\t\tTodoList");
                Console.Write("\t\t\t\t1. Add Todo\n\t\t\t\t2. See Todo\n\t\t\t\t3. Exit\n\t\t\t\t");
                Console.Write("= ");
                pilihan = Console.ReadLine();

                do
                {
                    switch (Convert.ToInt32(pilihan))
                    {
                        case 1:
                            inputTodo(todoList);
                            break;
                        case 2:
                            printAllTodo(todoList);
                            break;
                        default:
                            break;
                    }
                } while (pilihan == "1" && pilihan == "2");
            } while (pilihan != "3");


        }

        public static void inputTodo(List<Todo> todos)
        {
            string input;
            do
            {
                Console.Write("\t\t\t\tMasukkan Todo List = ");
                string nama = Console.ReadLine();
                Console.WriteLine();

                Todo todo = new Todo { Nama = nama };
                todos.Add(todo);

                Console.WriteLine("\t\t\t\tIngin menginput Todo lagi ? (Y/N)");
                Console.Write("\t\t\t\t");
                input = Console.ReadLine();
            } while (input.ToUpper() != "N");
        }

        public static void printAllTodo(List<Todo> todoList)
        {
            int index = 0;
            Console.WriteLine("\t\t\t\tNo\tTodo List");
            foreach (Todo item in todoList)
            {
                Console.WriteLine("\t\t\t\t{0}\t{1}", ++index, item.Nama);
                Console.WriteLine();
            }
        }

    }

    public class Todo
    {
        public string Nama { get; set; }
    }
}
