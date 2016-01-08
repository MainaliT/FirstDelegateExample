using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDelegateExampel
{

    //defining delegates. its called BinaryOp but you can call anything you want and you have to return integer value and it must take an argument or parameter
    public delegate int BinaryOp(int x, int y);

    //creates method that this delegates represent any of the function or all the fucntion
    public class SimpleMath
    {
        public int Add(int x, int y) { return x + y; }

        public int Substract(int x, int y) { return x - y; }

        public int SquareNumber(int a) { return a * a; }

    }

     class program
    {
        static void main(string[] args)
        {
            Console.WriteLine("***** Simple Delegate Example*****\n");

            // instantiate an instance of "simpleMathClass" see above
            SimpleMath m = new SimpleMath();

            // so now lets add the add method of the instance of 'simpleMath' to it.
            // 'BinaryOp is a delegates that takes 2 ints as parameters and returns an int as a result.
            BinaryOp b = new BinaryOp(m.Add);



            //invoke Add() method directly using delegate object
            Console.WriteLine("Direct invocation... 10+10 is {0}", b(10, 10));
            Console.ReadLine();

            //invoke Add() method indirectly using delegate object
            Console.WriteLine("Indirect invocation,.... 10 + 10 is {0}", b.Invoke(10, 10));
            Console.ReadLine();

            // Change the target method on the fly
            b = new BinaryOp(m.Substract);
            Console.WriteLine("Replace add with subtract");
            Console.ReadLine();

            //invoke the substract method by direactly invoking that delegate
            Console.WriteLine("Direct invocation.... 15 - 5 is {0}", b(15, 5));
            Console.ReadLine();

        }
    }
}
