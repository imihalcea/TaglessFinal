namespace CodageFinal
{
    public class ExpSymInt : ExpSym<int>
    {
        public int Num(int i) => i;
        public int Neg(int r) => -r;
        public int Add(int r1, int r2) => r1 + r2;
    }
}