enum State
{
Winner,
Looser, 
Playing,
NotInGame
}

class Player
{
	public string name; //имя игрока
	public int location; //позиция на поле
	public State state = State.NotInGame; //COстояние
	public int distanceTraveled = 0; //пройденное расстояние


	public Player(string name)
	{
	    this.name = name;
	    this.location = 1; //не в игре
	}


	public void Move(int steps)
	{
	    // пересчитать location
	    // изменить state, если необходимо
	}
}
