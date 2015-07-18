using System;
using System.Threading;

public class Game : IGame
{
    Board m_oBoard;
    Player m_oPlayer1;
    Player m_oPlayer2;
    private bool m_fPlayer1Turn;
    private bool m_fShouldQuit;
    const string baseBoard = " {0} | {1} | {2} \n-----------\n {3} | {4} | {5} \n-----------\n {6} | {7} | {8}\n\n";
	public Game()
	{
        m_oBoard = new Board();
        m_oPlayer1 = new Player();
        m_oPlayer1.setSymbol('O');
        m_oPlayer2 = new Player();
        m_oPlayer2.setSymbol('X');
        m_fPlayer1Turn = true;
        m_fShouldQuit = false;
	}

    public bool shouldQuit() {
        return m_fShouldQuit;
    }

    public bool run() {
        Console.Clear();
        setupPlayerNames();

        int numTiles = m_oBoard.getTiles().GetLength(0) - 1;
        displayBoard();
        while (true)
        {
            
            Thread.Sleep(1000);

            if (m_fPlayer1Turn)
            {
                performMove(m_oPlayer1);
            } else {
                performMove(m_oPlayer2);
            }
            displayBoard();
            if( m_oBoard.isFinished() ) {
                if( m_oBoard.hasWinner()){
                    displayWinner();
                } else {
                    displayDrawMessage();
                }

                return shouldPlayAgain();
                
            }
                
        }
    }

    public void setUp() { }

    public bool shouldPlayAgain(string injected = "") {

        string input;
        if (String.IsNullOrEmpty(injected))
        {
            Console.Write("Play again? Y(es)/N(o): ");
            input = Console.ReadLine();
        } else {
            input = injected;
        }

        if( String.Equals(input, "Y", StringComparison.CurrentCultureIgnoreCase) ||
            String.Equals(input, "Yes", StringComparison.CurrentCultureIgnoreCase) ) {
                return true;
        }
        return false;
    }

    public void setShouldQuit(bool value)
    {
        m_fShouldQuit = value;
    }

    public void displayBoard()
    {
        Tile[] boardTiles = m_oBoard.getTiles();
        Console.Clear();
        Console.Write("\n\n\n");
        Console.Write(String.Format(baseBoard, boardTiles[0].getValue(),
                                                boardTiles[1].getValue(),
                                                boardTiles[2].getValue(),
                                                boardTiles[3].getValue(),
                                                boardTiles[4].getValue(),
                                                boardTiles[5].getValue(),
                                                boardTiles[6].getValue(),
                                                boardTiles[7].getValue(),
                                                boardTiles[8].getValue()
            ));
    }

    private void performMove(IPlayer player)
    {
        int maxTileId = m_oBoard.getTiles().GetLength(0);
        int move = player.pickTile(maxTileId);
        while (!m_oBoard.isTileFree(move))
        {
            move = player.pickTile(maxTileId);
        }
        m_oBoard.setTile(move, player.getSymbol());
        m_fPlayer1Turn = !m_fPlayer1Turn;
    }

    private void displayWinner()
    {
         char winningSymbol = m_oBoard.getWinner();
         string winnerName;
         if( m_oPlayer1.getSymbol() == winningSymbol){
              winnerName = m_oPlayer1.getName();
          } else {
              winnerName = m_oPlayer2.getName();
          }
          Console.WriteLine(String.Format("{0} won!", winnerName) );
    }

    private void displayDrawMessage()
    {
        Console.WriteLine("Game over! Draw game");
    }

    private void setupPlayerNames()
    {
        Console.WriteLine("Please enter Player 1's name: ");
        string p1Name = Console.ReadLine();
        Console.WriteLine("Please enter Player 2's name: ");
        string p2Name = Console.ReadLine();
        m_oPlayer1.setName(p1Name);
        m_oPlayer2.setName(p2Name);
    }

}
