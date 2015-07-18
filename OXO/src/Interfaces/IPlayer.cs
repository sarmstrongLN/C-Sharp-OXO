using System;

interface IPlayer
{
    int pickTile(int maxTileId);
    string getName();
    void setName(string name);
}
