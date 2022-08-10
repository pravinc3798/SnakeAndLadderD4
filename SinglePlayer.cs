namespace SnakeAndLadder
{
    public class SinglePlayer
    {
        public static void Play()
        {
            Console.Write("Enter Player Name : ");
            var player = new Player(Console.ReadLine());
            Console.WriteLine("\n");

            byte end = 0;
            while (end < 100)
            {
                Console.WriteLine("{0}'s Turn >>>> Press Enter to Roll Die", player.Name);
                Console.ReadLine();
                end = player.Move();
            }
        }
    }
}
