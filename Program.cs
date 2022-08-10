namespace SnakeAndLadder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n\n ------ SNAKE AND LADDER ------ \n 1. Single Player \n 2. Two Player \n ");
            Console.Write(" Input number of Players (1 or 2) : ");
            var input = Console.ReadLine();

            switch (input)
            {
                case "1": SinglePlayer.Play(); break;
                case "2": MultiPlayer.Play(); break;
                default: Console.WriteLine("Invalid Input!!"); break;
            }
        }
    }
}
