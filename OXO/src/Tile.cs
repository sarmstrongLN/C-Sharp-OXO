using System;

public class Tile : ITile
{
    char m_cDisplayValue;

	public Tile()
	{
        m_cDisplayValue = ' ';
	}

    public void setValue(char val) {
        m_cDisplayValue = val;
    }

    public char getValue() {
        return m_cDisplayValue;
    }
}
