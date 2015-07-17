using System;

public class Player : IPlayer
{
    string m_sName;

	public Player()
	{
        m_sName = "Player";
	}

    public int pickTile(int max)
    {
        Random rand = new Random();
        return rand.Next(max);
    }

    public string getName()
    {
        return m_sName;
    }

    public void setName(string name)
    {
        m_sName = name;
    }
}
