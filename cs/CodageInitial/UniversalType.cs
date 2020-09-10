namespace CodageInitial
{
    public class Univ
    {
        private readonly object _value;

        public Univ(object value)
        {
            _value = value;
        }

        public bool AsBool() => 
            _value is bool value ? value : default;

        public int AsInt() => 
            _value is int value ? value : default;

        public string AsStr() =>
            _value is string value ? value : default;
    }

    public class UB : Univ
    {
        public UB(bool value) : base(value)
        {
        }
    }

    public class UI : Univ
    {
        public UI(int value) : base(value)
        {
        }
    }

    public class UStr : Univ
    {
        public UStr(object value) : base(value)
        {
        }
    }
    
    public static class UnivFactory
    {
        public static UB UB(bool b)=> new UB(b);
        public static UI UI(int i)=> new UI(i);
        
        public static UStr UStr(string s) => new UStr(s);
    }
}