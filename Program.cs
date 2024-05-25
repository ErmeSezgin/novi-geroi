using igra;



namespace igra

{

    class ConsoleGameEventListener : GameEventListener

    {

        public override void GameRound(Hero attacker, Hero defender, int attack)

        {

            string message = $"{attacker.Name} attacked {defender.Name} for {attack}.";

            if (defender.IsAlive)

            {

                message = message + $" but {defender.Name} survived.";

            }

            else

            {

                message = message + $" and {defender.Name} died.";

            }

            Console.WriteLine(message);

        }

    }



    internal class Program

    {

        static void Main(string[] args)

        {

            Knight knight = new Knight("Sir John");

            Rogue rogue = new Rogue("Slim Shady");

            MorganFreeman morganFreeman = new MorganFreeman("Morgan Freeman");

            Komur komur = new Komur("Komur");



            Arena arena = new Arena(knight, rogue, morganFreeman, komur);

            arena.EventListener = new ConsoleGameEventListener();



            Console.WriteLine("Let the war begin.");



            // Example of using special abilities

            morganFreeman.BecomeInvisible();

            komur.IgniteCoal(knight);



            Hero winner = arena.Battle();

            Console.WriteLine($"War is over. Winner is: {winner.Name}");

            Console.ReadLine();

        }

    }

}