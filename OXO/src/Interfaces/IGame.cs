using System;

public interface IGame
{
    void setUp();
    bool run();
    bool shouldQuit();
    bool shouldPlayAgain(string injectedResponse);
    void displayBoard();
}
