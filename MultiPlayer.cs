namespace SnakeAndLadder
{
    public class MultiPlayer
    {
        public static void Play()
        {
            Console.Write("Enter Player 1 Name : ");
            var player1 = new Player(Console.ReadLine());

            Console.Write("Enter Player 2 Name : ");
            var player2 = new Player(Console.ReadLine());

            Console.WriteLine("\n");

            byte end1 = 0;
            byte end2 = 0;

            while (end1 < 100 && end2 < 100)
            {
                Console.WriteLine("{0}'s Turn >>>> Press Enter to Roll Die ", player1.Name);
                Console.ReadLine();
                end1 = player1.Move();

                Console.WriteLine("{0}'s Turn >>>> Press Enter to Roll Die ", player2.Name);
                Console.ReadLine();
                end2 = player2.Move();

                if (end1 == 100)
                    Console.WriteLine("\n\n >>>>>{0} - WON !!!!  ", player1.Name);
                else if (end2 == 100)
                    Console.WriteLine("\n\n >>>>>{0} - WON !!!!  ", player2.Name);
            }
        }
    }
}
