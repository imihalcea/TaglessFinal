using System;

namespace CodageFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(tf1(new ExpSymStr()));
            Console.WriteLine(tf1(new ExpSymInt()));
            Console.WriteLine(tf2(new ExpSymStr(), new MulSymStr()));
            Console.WriteLine(tf2(new ExpSymInt(), new MulSymInt()));
        }
        
        private static R tf1<R>(ExpSym<R> exp) => 
            exp.Add(exp.Num(8), exp.Neg(exp.Add(exp.Num(1),exp.Num(2))));

        private static R tf2<R>(ExpSym<R> exp, MulSym<R> mexp) =>
             mexp.Mul(exp.Num(3), tf1(exp));
    }
}