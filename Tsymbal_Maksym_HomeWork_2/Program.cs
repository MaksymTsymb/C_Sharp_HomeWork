using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
//1.Зробити стек, реалізований на першому занятті узагальненим і щоб він міг працювати тільки із структурами
/// </summary>


namespace Tsymbal_Maksym_HomeWork_2 
{
    public class Stack<T> where T: struct
    {
        private T[] array;

        private int elementCounter;

        public Stack()
        {
            array = new T[10];
            elementCounter = 0;
        }

        public T Peek()
        {
            if (elementCounter > 0)
            {
                return array[elementCounter];
            }
            else
            {
                throw new Exception("Stack is empty!");
            }
        }

        public void Push(T value)
        {
            elementCounter++;

            if (elementCounter >= (array.Length * 0.8))
            {
                array = ArrayExpand();
                array[elementCounter] = value;
            }
            else array[elementCounter] = value;
        }

        public T Pop()
        {
            T variable1;

            if (elementCounter > 0)
            {
                variable1 = array[elementCounter];
                array[elementCounter] = default(T);

                elementCounter--;

                return variable1;
            }
            else
            {
                throw new Exception("Stack is empty!");
            }
        }

        private T[] ArrayExpand()
        {
            T[] newArray = new T[array.Length * 2];
            array.CopyTo(newArray, 0);
            return newArray;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> myStack = new Stack<char>();

            myStack.Push('|');
            myStack.Push('2');
            myStack.Push('3');
            myStack.Push('4');
            myStack.Push('S');

            Console.WriteLine(myStack.Pop());

            myStack.Push('6');
            myStack.Push('7');
            myStack.Push('8');
            myStack.Push('9');
            myStack.Push('Q');

            // Method Pop executes 10 times:
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());

            myStack.Push('$'); //It used to be element 'S' before line 89

            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());

            // Exception case:
            //Console.WriteLine(myStack.Pop());


            Console.ReadKey();
        }
    }
}
