using System;

interface IBoard
{
    bool hasFinished();
    bool hasWinner();
    char getWinner();
    bool isTileFree(int tileId);
    void makeMove(int tileId, char playerChar);

}
