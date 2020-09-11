namespace CodageFinal
{
    public class MulSymInt : ExpSymInt, MulSym<int>
    {
        public int Mul(int r1, int r2) => r1 * r2;
    }
}