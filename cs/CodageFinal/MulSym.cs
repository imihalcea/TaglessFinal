namespace CodageFinal
{
    public interface MulSym<R> : ExpSym<R>
    {
        R Mul(R r1, R r2);
    }
}