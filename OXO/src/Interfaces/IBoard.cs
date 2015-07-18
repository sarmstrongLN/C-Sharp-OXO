using System;

interface IBoard
{
    bool isFinished();
    void resetBoard();
    bool setTile(int tileId, char symbol);
    bool isTileFree(int tileId);
    bool hasWinner();
    char getWinner();
    Tile[] getTiles(); 

}
