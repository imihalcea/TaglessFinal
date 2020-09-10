namespace CodageFinal
{

    public interface MulSym<R> : ExpSym<R>
    {
        R Mul(R r1, R r2);
    }
    
    public interface ExpSym<R>
    {
        R Num(int i);
        R Neg(R r);
        R Add(R r1, R r2);
    }

    public class MulSymInt : ExpSymInt, MulSym<int>
    {
        public int Mul(int r1, int r2) => r1 * r2;
    }

    public class ExpSymInt : ExpSym<int>
    {
        public int Num(int i) => i;
        public int Neg(int r) => -r;
        public int Add(int r1, int r2) => r1 + r2;
    }

    public class MulSymStr : ExpSymStr, MulSym<string>
    {
        public string Mul(string r1, string r2) => $"{r1} * {r2}";
    }
    
    public class ExpSymStr : ExpSym<string>
    {
        public string Num(int i) => i.ToString();
        public string Neg(string r) => $"-({r})";
        public string Add(string r1, string r2) => $"{r1} + {r2}";
    }
}