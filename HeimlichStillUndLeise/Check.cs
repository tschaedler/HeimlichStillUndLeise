using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeimlichStillUndLeise
{
    public class Check
    {
        public static bool CheckLeft(int size, Matchfield matchfield, char aktPlayer, char nxtPlayer, int y, int xPos)
        {
            bool stoneOfNextPlayerFound = false;
            for (int x = xPos-1; x >= 0 && x <= size - 1; x--)
            {
                char currentFieldValue = matchfield.GetField(y, x);

                if (currentFieldValue == ' ')
                {
                    return false;
                }

                if (currentFieldValue == nxtPlayer)
                {
                    stoneOfNextPlayerFound = true;
                    continue;
                }

                if (currentFieldValue == aktPlayer && stoneOfNextPlayerFound)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public static bool CheckRight(int size, Matchfield matchfield, char aktPlayer, char nxtPlayer, int y, int xPos)
        {
            bool stoneOfNextPlayerFound = false;
            for (int x = xPos+1; x >= 0 && x <= size - 1; x++)
            {
                char currentFieldValue = matchfield.GetField(y, x);

                if (currentFieldValue == ' ')
                {
                    return false;
                }

                if (currentFieldValue == nxtPlayer)
                {
                    stoneOfNextPlayerFound = true;
                    continue;
                }

                if (currentFieldValue == aktPlayer && stoneOfNextPlayerFound)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public static bool CheckTop(int size, Matchfield matchfield, char aktPlayer, char nxtPlayer, int yPos, int x)
        {
            bool stoneOfNextPlayerFound = false;
            for (int y = yPos-1; y >= 0 && y <= size - 1; y--) 
            {
                char currentFieldValue = matchfield.GetField(y, x);

                if (currentFieldValue == ' ')
                {
                    return false;
                }

                if (currentFieldValue == nxtPlayer)
                {
                    stoneOfNextPlayerFound = true;
                    continue;
                }

                if (currentFieldValue == aktPlayer && stoneOfNextPlayerFound)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public static bool CheckTopLeft(int size, Matchfield matchfield, char aktPlayer, char nxtPlayer, int yPos, int xPos)
        {
            bool stoneOfNextPlayerFound = false;
            for (int y = yPos - 1, x = xPos-1; x >= 0 && x <= size - 1 && y >= 0 && y <= size - 1; x--, y--)
            {
                char currentFieldValue = matchfield.GetField(y, x);

                if (currentFieldValue == ' ')
                {
                    return false;
                }

                if (currentFieldValue == nxtPlayer)
                {
                    stoneOfNextPlayerFound = true;
                    continue;
                }

                if (currentFieldValue == aktPlayer && stoneOfNextPlayerFound)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public static bool CheckTopRight(int size, Matchfield matchfield, char aktPlayer, char nxtPlayer, int yPos, int xPos)
        {
            bool stoneOfNextPlayerFound = false;
            for (int y = yPos - 1, x = xPos + 1; x >= 0 && x <= size - 1 && y >= 0 && y <= size - 1; x++, y--)
            {
                char currentFieldValue = matchfield.GetField(y, x);

                if (currentFieldValue == ' ')
                {
                    return false;
                }

                if (currentFieldValue == nxtPlayer)
                {
                    stoneOfNextPlayerFound = true;
                    continue;
                }

                if (currentFieldValue == aktPlayer && stoneOfNextPlayerFound)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public static bool CheckBottom(int size, Matchfield matchfield, char aktPlayer, char nxtPlayer, int yPos, int x)
        {
            bool stoneOfNextPlayerFound = false;
            for (int y = yPos+1; y >= 0 && y <= size - 1; y++)
            {
                char currentFieldValue = matchfield.GetField(y, x);

                if (currentFieldValue == ' ')
                {
                    return false;
                }

                if (currentFieldValue == nxtPlayer)
                {
                    stoneOfNextPlayerFound = true;
                    continue;
                }

                if (currentFieldValue == aktPlayer && stoneOfNextPlayerFound)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public static bool CheckBottomLeft(int size, Matchfield matchfield, char aktPlayer, char nxtPlayer, int yPos, int xPos)
        {
            bool stoneOfNextPlayerFound = false;
            for (int y = yPos + 1, x = xPos-1; x >= 0 && x <= size - 1 && y >= 0 && y <= size - 1; x--, y++)
            {
                char currentFieldValue = matchfield.GetField(y, x);

                if (currentFieldValue == ' ')
                {
                    return false;
                }

                if (currentFieldValue == nxtPlayer)
                {
                    stoneOfNextPlayerFound = true;
                    continue;
                }

                if (currentFieldValue == aktPlayer && stoneOfNextPlayerFound)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public static bool CheckBottomRight(int size, Matchfield matchfield, char aktPlayer, char nxtPlayer, int yPos, int xPos)
        {
            bool stoneOfNextPlayerFound = false;
            for (int y = yPos+1, x = xPos + 1; x >= 0 && x <= size - 1 && y >= 0 && y <= size - 1; x++, y++)
            {
                char currentFieldValue = matchfield.GetField(y, x);

                if (currentFieldValue == ' ')
                {
                    return false;
                }

                if (currentFieldValue == nxtPlayer)
                {
                    stoneOfNextPlayerFound = true;
                    continue;
                }

                if (currentFieldValue == aktPlayer && stoneOfNextPlayerFound)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        //Überprüfungen ob der nächste Spieler noch einen Zug machen kann
        public static bool CheckLeftNextTurn(int size, Matchfield matchfield, char aktPlayer, char nxtPlayer, int y, int xPos)
        {
            bool stoneOfNextPlayerFound = false;
            for (int x = xPos - 1; x >= 0 && x <= size - 1; x--)
            {
                char currentFieldValue = matchfield.GetField(y, x);

                if (currentFieldValue == ' ')
                {
                    return false;
                }

                if (currentFieldValue == aktPlayer)
                {
                    stoneOfNextPlayerFound = true;
                    continue;
                }

                if (currentFieldValue == nxtPlayer && stoneOfNextPlayerFound)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public static bool CheckRightNextTurn(int size, Matchfield matchfield, char aktPlayer, char nxtPlayer, int y, int xPos)
        {
            bool stoneOfNextPlayerFound = false;
            for (int x = xPos + 1; x >= 0 && x <= size - 1; x++)
            {
                char currentFieldValue = matchfield.GetField(y, x);

                if (currentFieldValue == ' ')
                {
                    return false;
                }

                if (currentFieldValue == aktPlayer)
                {
                    stoneOfNextPlayerFound = true;
                    continue;
                }

                if (currentFieldValue == nxtPlayer && stoneOfNextPlayerFound)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public static bool CheckTopNextTurn(int size, Matchfield matchfield, char aktPlayer, char nxtPlayer, int yPos, int x)
        {
            bool stoneOfNextPlayerFound = false;
            for (int y = yPos - 1; y >= 0 && y <= size - 1; y--)
            {
                char currentFieldValue = matchfield.GetField(y, x);

                if (currentFieldValue == ' ')
                {
                    return false;
                }

                if (currentFieldValue == aktPlayer)
                {
                    stoneOfNextPlayerFound = true;
                    continue;
                }

                if (currentFieldValue == nxtPlayer && stoneOfNextPlayerFound)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public static bool CheckTopLeftNextTurn(int size, Matchfield matchfield, char aktPlayer, char nxtPlayer, int yPos, int xPos)
        {
            bool stoneOfNextPlayerFound = false;
            for (int y = yPos - 1, x = xPos - 1; x >= 0 && x <= size - 1 && y >= 0 && y <= size - 1; x--, y--)
            {
                char currentFieldValue = matchfield.GetField(y, x);

                if (currentFieldValue == ' ')
                {
                    return false;
                }

                if (currentFieldValue == aktPlayer)
                {
                    stoneOfNextPlayerFound = true;
                    continue;
                }

                if (currentFieldValue == nxtPlayer && stoneOfNextPlayerFound)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public static bool CheckTopRightNextTurn(int size, Matchfield matchfield, char aktPlayer, char nxtPlayer, int yPos, int xPos)
        {
            bool stoneOfNextPlayerFound = false;
            for (int y = yPos - 1, x = xPos + 1; x >= 0 && x <= size - 1 && y >= 0 && y <= size - 1; x++, y--)
            {
                char currentFieldValue = matchfield.GetField(y, x);

                if (currentFieldValue == ' ')
                {
                    return false;
                }

                if (currentFieldValue == aktPlayer)
                {
                    stoneOfNextPlayerFound = true;
                    continue;
                }

                if (currentFieldValue == nxtPlayer && stoneOfNextPlayerFound)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public static bool CheckBottomNextTurn(int size, Matchfield matchfield, char aktPlayer, char nxtPlayer, int yPos, int x)
        {
            bool stoneOfNextPlayerFound = false;
            for (int y = yPos + 1; y >= 0 && y <= size - 1; y++)
            {
                char currentFieldValue = matchfield.GetField(y, x);

                if (currentFieldValue == ' ')
                {
                    return false;
                }

                if (currentFieldValue == aktPlayer)
                {
                    stoneOfNextPlayerFound = true;
                    continue;
                }

                if (currentFieldValue == nxtPlayer && stoneOfNextPlayerFound)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public static bool CheckBottomLeftNextTurn(int size, Matchfield matchfield, char aktPlayer, char nxtPlayer, int yPos, int xPos)
        {
            bool stoneOfNextPlayerFound = false;
            for (int y = yPos + 1, x = xPos - 1; x >= 0 && x <= size - 1 && y >= 0 && y <= size - 1; x--, y++)
            {
                char currentFieldValue = matchfield.GetField(y, x);

                if (currentFieldValue == ' ')
                {
                    return false;
                }

                if (currentFieldValue == aktPlayer)
                {
                    stoneOfNextPlayerFound = true;
                    continue;
                }

                if (currentFieldValue == nxtPlayer && stoneOfNextPlayerFound)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public static bool CheckBottomRightNextTurn(int size, Matchfield matchfield, char aktPlayer, char nxtPlayer, int yPos, int xPos)
        {
            bool stoneOfNextPlayerFound = false;
            for (int y = yPos + 1, x = xPos + 1; x >= 0 && x <= size - 1 && y >= 0 && y <= size - 1; x++, y++)
            {
                char currentFieldValue = matchfield.GetField(y, x);

                if (currentFieldValue == ' ')
                {
                    return false;
                }

                if (currentFieldValue == aktPlayer)
                {
                    stoneOfNextPlayerFound = true;
                    continue;
                }

                if (currentFieldValue == nxtPlayer && stoneOfNextPlayerFound)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}
