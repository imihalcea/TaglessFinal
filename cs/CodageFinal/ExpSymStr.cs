namespace CodageFinal
{
    public class ExpSymStr : ExpSym<string>
    {
        public string Num(int i) => i.ToString();
        public string Neg(string r) => $"-({r})";
        public string Add(string r1, string r2) => $"{r1} + {r2}";
    }
}