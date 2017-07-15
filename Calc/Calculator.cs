namespace Calc
{
    public class Calculator
    {
        public int Result { get; private set; }

        public void Add(int x, int y) => Result = x + y;
    }
}
