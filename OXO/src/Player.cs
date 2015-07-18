using System;

public class Player : IPlayer
{
    string m_sName;
    char m_cSymbol;

	public Player() {
        m_sName = "Player";
	}

    public int pickTile(int max) {
        Random rand = new Random();
        return rand.Next(max);
    }

    public string getName() {
        return m_sName;
    }

    public void setName(string name) {
        m_sName = name;
    }

    public void setSymbol(char symbol) {
        m_cSymbol = symbol;
    }

    public char getSymbol() {
        return m_cSymbol;
    }
}
