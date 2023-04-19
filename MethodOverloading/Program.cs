namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }
        public static string Add(int x, int y, bool dollars)
        {
            var z = x + y;

            if(dollars == true && z == 1)
            {
                return $"${z} dollar";
            }
            else
            {
                return $"${z} dollars";
            }
        }
        static void Main(string[] args)
        {
            var x = 400;
            var y = 20;
            var input = Add(x, y);
            var a = 4.2m;
            var b = 1.07m;
            var decInput = Add(a, b);
            var result = Add(1, 0, true);
            Console.WriteLine(input);
            Console.WriteLine(decInput);
            Console.WriteLine(result);
        }
    }
}
