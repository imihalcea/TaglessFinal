namespace CodageFinal
{
    public class MulSymStr : ExpSymStr, MulSym<string>
    {
        public string Mul(string r1, string r2) => $"{r1} * {r2}";
    }
}