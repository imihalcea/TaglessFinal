namespace CodageInitial
{
    public interface Exp
    {
        
    }

    public class Num : Exp
    {
        public int I { get; }

        public Num(int i)
        {
            I = i;
        }
    }

    public class Bool : Exp
    {
        public bool B { get; }

        public Bool(bool b)
        {
            B = b;
        }
    }

    public class Neg:Exp
    {
        public Exp Exp { get; }

        public Neg(Exp exp)
        {
            Exp = exp;
        }
    }

    public class Add:Exp
    {
        public Exp E1 { get; }
        public Exp E2 { get; }

        public Add(Exp e1, Exp e2)
        {
            E1 = e1;
            E2 = e2;
        }
    }

    public class Mul:Exp
    {
        public Exp E1 { get; }
        public Exp E2 { get; }

        public Mul(Exp e1, Exp e2)
        {
            E1 = e1;
            E2 = e2;
        }
    }

    public class Or:Exp
    {
        public Exp E1 { get; }
        public Exp E2 { get; }

        public Or(Exp e1, Exp e2)
        {
            E1 = e1;
            E2 = e2;
        }
    }
    
    public class And:Exp
    {
        public Exp E1 { get; }
        public Exp E2 { get; }

        public And(Exp e1, Exp e2)
        {
            E1 = e1;
            E2 = e2;
        }
    }
    
    public class Leq:Exp
    {
        public Exp E1 { get; }
        public Exp E2 { get; }

        public Leq(Exp e1, Exp e2)
        {
            E1 = e1;
            E2 = e2;
        }
    }
    
}