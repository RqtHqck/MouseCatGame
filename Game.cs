namespace MouseCatGame
{
    class Game
    {
        public int size; //размер игрового поля
        public Player cat;
        public Player mouse;
        public GameState state;
        public static string InputFile = "1.ChaseData.txt";
        public static string OutputFile = "1.PursuitLog.txt";


        public Game (int size)
        {
            this.size = size; // размер поля
            cat = new Player("Cat");
            mouse = new Player("Mouse");
            state = GameState.Start; // статус
        }

        public void Run()
        {
            while (state != GameState.End) //пока не конец игры
            {
                // прочиDoCommandтать команду  
                // если все команды исчерпаны, закончить игру (state 
                //выполнить команду DoMoveCommand или DoPrintCommand 
                // если мышь поймана, закончить игру (state = GameState.End;)
            }
        }
            
        private void DoMoveCommand(char command, int steps)
        {
            switch (command)
            {
                case 'M': mouse.Move(steps); break;
                case 'C': cat.Move(steps); break;
            }
        }

        private void DoPrintCommand()
        {
            //вывод позиций игроков и р асстояния между ними (если это возможно)
        }

        private int GetDistance()
        {
            //найти расстояние между игроками cat.location - mouse.location 
            return 0;
        }
    }
}
