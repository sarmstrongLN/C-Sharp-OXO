using System;

public interface IGame
{
    void setUp();
    void run();
    bool shouldQuit();
    void promptForQuit(string inject);
}
