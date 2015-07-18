using System;
using System.Collections.Generic;

public class Board : IBoard
{
    Tile[] m_aTiles;
    bool m_fIsFinished;
    bool m_fHasWinner;
    char m_cWinner;
    readonly int BOARD_SIZE = 9;
    List<int[]> m_aWinningLines;

    public Board()
	{
        resetBoard();
        setupWinningLines();
	}

    public void resetBoard()
    {
        m_aTiles = new Tile[BOARD_SIZE];
        for (int i = 0; i < BOARD_SIZE; i++)
        {
            m_aTiles[i] = new Tile();
        }
        m_fIsFinished = false;
        m_fHasWinner = false;
        m_cWinner = ' ';
    }

    private void setupWinningLines()
    {
        m_aWinningLines = new List<int[]>();
        m_aWinningLines.Add(new int[3] { 0, 1, 2 });
        m_aWinningLines.Add(new int[3] { 3, 4, 5 });
        m_aWinningLines.Add(new int[3] { 6, 7, 8 });
        m_aWinningLines.Add(new int[3] { 0, 3, 6 });
        m_aWinningLines.Add(new int[3] { 1, 4, 7 });
        m_aWinningLines.Add(new int[3] { 2, 5, 8 });
        m_aWinningLines.Add(new int[3] { 0, 4, 8 });
        m_aWinningLines.Add(new int[3] { 2, 4, 6 });
    }
    public bool setTile(int tileId, char playerSymbol)
    {
        if (isTileFree(tileId) && !m_fIsFinished)
        {
            m_aTiles[tileId].setValue(playerSymbol);
            checkBoard();
            return true;
        }
        return false;
    }

    public bool isTileFree(int tileId)
    {
        return m_aTiles[tileId].isFree();
    }

    public bool isFinished(){
        return m_fIsFinished;
    }

    public bool hasWinner()
    {
        return m_fHasWinner;
    }

    public char getWinner()
    {
        return m_cWinner;
    }

    public Tile[] getTiles()
    {
        return m_aTiles;
    }

    private void checkBoard()
    {
        checkForWinner();
        if (!m_fIsFinished)
        {
            checkIfBoardFull();
        }
        
    }

    private void checkIfBoardFull()
    {
        bool full = true;
        foreach (Tile tile in m_aTiles)
        {
            if (tile.getValue() == Tile.DEFAULT_VALUE)
            {
                full = false;
                return;
            }
        }

        if (full)
        {
            setIsFinished();
        }
        
    }
    private void checkForWinner()
    {
        int lineIndex = 0;
        while (lineIndex < m_aWinningLines.Count)
        {
            int[] aLine = m_aWinningLines[lineIndex];
       
            char first = m_aTiles[aLine[0]].getValue();
            if (first == Tile.DEFAULT_VALUE)
            {
                lineIndex++;
                continue;
            }

            bool lineWins = true;
            for (int i = 0; i < aLine.Length; i++)
            {
                if (m_aTiles[aLine[i]].getValue() != first)
                {
                    lineWins = false;
                    break;
                }
            }
            if (lineWins)
            {
                setWinner(first);
                return;
            }
            lineIndex++;
        }
    }

    private void setWinner(char winner = ' ')
    {
        setHasWinner();
        setIsFinished();
        m_cWinner = winner;
    }

    private void setHasWinner()
    {
        m_fHasWinner = true;
    }
    private void setIsFinished()
    {
        m_fIsFinished = true;
    }
}
