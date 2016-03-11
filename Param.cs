namespace ExtractTransform
{
    public class Param
    {
        public string Regex;
        public long Start;
        public long Delta;
        public long Current;
        public Param(string regex, long start, long delta)
        {
            Regex = regex;
            Start = start;
            Delta = delta;
            Current = start;
        }
    }
}