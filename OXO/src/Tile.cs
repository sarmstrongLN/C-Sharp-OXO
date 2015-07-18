using System;

public class Tile : ITile
{
    public const char DEFAULT_VALUE = ' ';
    char m_cDisplayValue;

	public Tile() {
        m_cDisplayValue = DEFAULT_VALUE;
	}

    public bool isFree() {
        return getValue() == DEFAULT_VALUE;
    }

    public void setValue(char val) {
        m_cDisplayValue = val;
    }

    public char getValue() {
        return m_cDisplayValue;
    }
}
