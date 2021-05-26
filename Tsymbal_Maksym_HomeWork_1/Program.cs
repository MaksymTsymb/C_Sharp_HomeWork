using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
//Імплементувати власну структуру даних Стек. 
//Ваш клас має містити методи Push, Pop i Peek. За основу можна взяти масив, тобто щоб в середині стеку елементи зберігалися в масиві. 
//Для спрощення, реалізуйте його для роботи лише з одним типом даних (наприклад int).
//При заповненні внутрішнього масиву на 80% він має динамічно розширитися (збільшитися вдвічі) і скоіпювати в новостворений масив усі елементи з попереднього.
/// </summary>
 

namespace Tsymbal_Maksym_HomeWork_1
{
    public class Stack
    {
        private int[] array;

        private int elementCounter;
        
        public Stack(int volume)
        {
            array = new int[volume];
            elementCounter = 0;
        }

        public int Peek()
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

        public void Push(int value)
        {
            elementCounter++;

            if (elementCounter >= (array.Length * 0.8))
            {
                array = ArrayExpand();
                array[elementCounter] = value;
            }
            else array[elementCounter] = value;
        }

        public int Pop()
        {
            int variable1;

            if (elementCounter > 0)
            {
                variable1 = array[elementCounter];
                array[elementCounter] = 0;

                elementCounter--;

                return variable1;
            }
            else
            {
                throw new Exception("Stack is empty!");
            }
        }

        private int[] ArrayExpand()
        {
            int[] newArray = new int[array.Length * 2];
            array.CopyTo(newArray, 0);
            return newArray;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack(5);

            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);

            Console.WriteLine(myStack.Pop());

            myStack.Push(6);
            myStack.Push(7);
            myStack.Push(8);
            myStack.Push(9);
            myStack.Push(10);

            // Method Pop executes 10 times:
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());

            myStack.Push(99); //It used to be element 5 before line 92

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
