using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();

            stack.Push("Hulk");
            stack.Push("Captain America");
            stack.Push("Black Widow");

            Console.WriteLine( stack.Peek() );  // Black Widow

            Console.WriteLine( stack.Pop() );   // Black Widow

            Console.WriteLine( stack.Pop() );   // Captain America


            

        }
    }
}
