using System;

public class Game : IGame
{
    private bool m_fShouldQuit;
	public Game()
	{
        m_fShouldQuit = false;
	}

    public bool shouldQuit() {
        return m_fShouldQuit;
    }

    public void run() { }

    public void setUp() { }

    public void promptForQuit(string injected = "") {

        string input;
        if (String.IsNullOrEmpty(injected))
        {
            Console.Write("Quit? Y(es)/N(o): ");
            input = Console.ReadLine();
        } else {
            input = injected;
        }

        if( String.Equals(input, "Y", StringComparison.CurrentCultureIgnoreCase) ||
            String.Equals(input, "Yes", StringComparison.CurrentCultureIgnoreCase) ) {
            setShouldQuit(true);
        }
    }

    public void setShouldQuit(bool value)
    {
        m_fShouldQuit = value;
    }
}
