using System;
using System.Diagnostics;
using static CodageInitial.UnivFactory;

namespace CodageInitial
{
    public static class Evaluateur
    {
        public  static Univ Eval(Exp exp) =>
            exp switch
            {
                Num e => UI(e.I),
                Bool e => UB(e.B),
                
                Neg e => UI(-Eval(e.Exp).AsInt()),
                Add e => UI(Eval(e.E1).AsInt()+Eval(e.E2).AsInt()),
                Mul e => UI(Eval(e.E1).AsInt()*Eval(e.E2).AsInt()),
                
                And e => UB(Eval(e.E1).AsBool() && Eval(e.E2).AsBool()),
                Or e => UB(Eval(e.E1).AsBool() || Eval(e.E2).AsBool()),
                _ => throw new NotSupportedException()
            };

        public static Univ Print(Exp exp) =>
            exp switch
            {
                Num e => UStr(e.I.ToString()),
                Bool e => UStr(e.B.ToString()),
                
                Neg e => UStr($"- ({Print(e.Exp).AsStr()})"),
                Add e => UStr($"{Print(e.E1).AsStr()} + {Print(e.E2).AsStr()}"),
                _ => throw new NotSupportedException()
            };
    }
}