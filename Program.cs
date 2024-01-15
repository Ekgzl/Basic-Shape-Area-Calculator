namespace ShapeAreaCalculator;

class Program
{
    static void Main(string[] args)
    {

        float pi = 3.14f;
        float vertical, horizontal;
        char isYes;
        do
        {
            char switchKey;
            do
            {
                Console.WriteLine("Please enter shape: ");
                Console.WriteLine("1- Rectangle(r)\n2- Triangle(t)\n3-Circle(c)");
                switchKey = Console.ReadLine()[0];
            } while (switchKey != 'R' && switchKey != 'r' && switchKey != 'T'&& switchKey != 't'&& switchKey != 'c' && switchKey != 'C');
            
            
            switch (switchKey)
            {
                case 't':
                case 'T': 
                    Console.WriteLine("Please provide height: ");
                    vertical = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please provide basement of triangle: ");
                    horizontal = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(vertical * horizontal /2.0f);
                    break;
                case 'R':
                case 'r':
                    Console.WriteLine("Please provide height: ");
                    vertical = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please provide length: ");
                    horizontal = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(vertical * horizontal);
                    break;
                case 'C':
                case 'c':
                    Console.WriteLine("Please provide radius: ");
                    vertical = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(vertical*pi*vertical);
                    break;
            }

            System.Threading.Thread.Sleep(2500);
            Console.Clear();
            do
            {
                Console.WriteLine("Do you want to play again?:[Y]/[N] ");
                isYes = Console.ReadLine()[0];
            } while (isYes != 'y' && isYes != 'Y' && isYes != 'N' && isYes != 'n');
            
        } while (isYes == 'y' || isYes == 'Y');
    }
}