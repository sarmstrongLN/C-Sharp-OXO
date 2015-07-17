using System;

public class Board : IBoard
{
	public Board()
	{
	}

    public void makeMove(int tileId, char playerSymbol) { }

    public bool isTileFree(int tileId)
    {
        return true;
    }

    public bool hasFinished(){
        return false;
    }

    public bool hasWinner()
    {
        return false;
    }

    public char getWinner()
    {
        return ' ';
    }

}
