namespace CodageInitial
{
    public static class ExpFactory
    {
        public static Exp Num(int i) => new Num(i);
        public static Exp Neg(Exp e1) => new Neg(e1);
        
        public static Exp Add(Exp e1, Exp e2) => new Add(e1,e2);
        
        public static Exp Mul(Exp e1, Exp e2) => new Mul(e1,e2);
        
        public static Exp Or(Exp e1, Exp e2) => new Or(e1,e2);
        
        public static Exp And(Exp e1, Exp e2) => new And(e1,e2);
        
        public static Exp Leq(Exp e1, Exp e2) => new Leq(e1,e2);
    }
}