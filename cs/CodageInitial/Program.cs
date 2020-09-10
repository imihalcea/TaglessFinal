using System;
using static CodageInitial.Evaluateur;
using static CodageInitial.ExpFactory;

namespace CodageInitial
{
    class Program
    {
        static void Main(string[] args)
        {
            var ti = Add(Num(8), Neg(Add(Num(1), Num(2))));
            var result = Eval(ti).AsInt();
            Console.WriteLine($"{Print(ti).AsStr()} = {Eval(ti).AsInt()}");
        }
    }
}