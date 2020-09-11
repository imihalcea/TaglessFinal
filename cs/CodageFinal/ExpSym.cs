namespace CodageFinal
{
    public interface ExpSym<R>
    {
        R Num(int i);
        R Neg(R r);
        R Add(R r1, R r2);
    }
}