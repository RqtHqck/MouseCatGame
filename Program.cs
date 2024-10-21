namespace MouseCatGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Game.InputFile = "1.ChaseData.txt"; // Input
            Game.OutputFile = "1.ChaseData.txt"; // Output

            Game game = new Game(16); // Создали инстанс класса Game
            game.Run(); // запуск игры и вывод результатов
        }
    }
}
