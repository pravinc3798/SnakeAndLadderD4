namespace SnakeAndLadder
{
    public class Player
    {
        public string Name;
        public byte CurrentPostition = 0;

        public Player(string name)
        {
            Name = name;
        }

        public static byte RollDice()
        {
            var diceRoll = new Random();
            var Result = Convert.ToByte(diceRoll.Next(1,7));
            return Result;
        }

        public byte Move()
        {
            // https://www.istockphoto.com/vector/ancient-snakes-and-ladders-gm165761218-15915692
            // using above link to determine snake and ladder lengths

            Dictionary<byte, byte> Snakes = new Dictionary<byte, byte>();
            Snakes.Add(10, 4); Snakes.Add(22, 4); Snakes.Add(55, 40); Snakes.Add(65, 27); Snakes.Add(68, 17); Snakes.Add(69, 20); Snakes.Add(76, 33); Snakes.Add(88, 17); Snakes.Add(99, 17);

            Dictionary<byte, byte> Ladders = new Dictionary<byte, byte>();
            Ladders.Add(4, 12); Ladders.Add(17, 22); Ladders.Add(21, 39); Ladders.Add(26, 9); Ladders.Add(32, 16); Ladders.Add(56, 18); Ladders.Add(62, 18); Ladders.Add(86, 8);

            var dieResult = RollDice();
            CurrentPostition += dieResult;
            Console.WriteLine("Die Result : {0}", dieResult);

            if (CurrentPostition >= 94)
            {
                if (CurrentPostition  > 100)
                {
                    Console.WriteLine("Can't go forward");
                    CurrentPostition -= dieResult;
                }
            }

            foreach (var snake in Snakes.Keys)
            {
                if (CurrentPostition == snake)
                {
                    Console.WriteLine("Ohh Landed on Snake at {0}, Down by {1} blocks", snake, Snakes[snake]);
                    CurrentPostition -= Snakes[snake];
                }
                    
            }
            
            foreach (var ladder in Ladders.Keys)
            {
                if (CurrentPostition == ladder)
                {
                    Console.WriteLine("Found a Ladder at {0}, Up by {1} blocks", ladder, Ladders[ladder]);
                    CurrentPostition += Ladders[ladder];
                }
            }
            Console.WriteLine("{0} Position : {1} \n",Name ,CurrentPostition);
            return CurrentPostition;
        }
    }
}
