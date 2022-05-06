public static class Kata
{
    static void Main()
    {
        MathCheck.AreaOrPerimeter(4, 4);
        MathCheck.AreaOrPerimeter(6, 10);
    }

    public class MathCheck
    {
        public static int AreaOrPerimeter(int l, int w)
        {
            return l == w ? l * w : 2 * (l + w);
        }
    }
}