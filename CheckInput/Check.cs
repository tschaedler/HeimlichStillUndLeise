using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckInput
{
    public static class Check
    {
        public static bool CheckLeft(int size, char[,] matchfield, char aktPlayer, char nxtPlayer, int xPos, int yPos)
        {
            bool stoneOfNextPlayerFound = false;
            for (int x = yPos; x >= 0 && x <= size - 1; x--)
            {
                char currentFieldValue = matchfield[xPos, yPos];

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
        public static bool CheckRight(int size, char[,] matchfield, char aktPlayer, char nxtPlayer, int xPos, int yPos)
        {
            bool stoneOfNextPlayerFound = false;
            for (int x = yPos; x >= 0 && x <= size - 1; x++)
            {
                char currentFieldValue = matchfield[xPos, yPos];

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
        public static bool CheckTop(int size, char[,] matchfield, char aktPlayer, char nxtPlayer, int xPos, int yPos)
        {
            bool stoneOfNextPlayerFound = false;
            for (int x = xPos; x >= 0 && x <= size - 1; x--)
            {
                char currentFieldValue = matchfield[xPos, yPos];

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
        public static bool CheckTopLeft(int size, char[,] matchfield, char aktPlayer, char nxtPlayer, int xPos, int yPos)
        {
            bool stoneOfNextPlayerFound = false;
            for (int x = xPos, y = yPos; x >= 0 && x <= size - 1 && y >= 0 && y <= size - 1; x--, y--)
            {
                char currentFieldValue = matchfield[xPos, yPos];

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
        public static bool CheckTopRight(int size, char[,] matchfield, char aktPlayer, char nxtPlayer, int xPos, int yPos)
        {
            bool stoneOfNextPlayerFound = false;
            for (int x = xPos, y = yPos; x >= 0 && x <= size - 1 && y >= 0 && y <= size - 1; x--, y++)
            {
                char currentFieldValue = matchfield[xPos, yPos];

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
        public static bool CheckBottom(int size, char[,] matchfield, char aktPlayer, char nxtPlayer, int xPos, int yPos)
        {
            bool stoneOfNextPlayerFound = false;
            for (int x = xPos; x >= 0 && x <= size - 1; x++)
            {
                char currentFieldValue = matchfield[x, yPos];

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
        public static bool CheckBottomLeft(int size, char[,] matchfield, char aktPlayer, char nxtPlayer, int xPos, int yPos)
        {
            bool stoneOfNextPlayerFound = false;
            for (int x = xPos, y = yPos; x >= 0 && x <= size - 1 && y >= 0 && y <= size - 1; x++, y--)
            {
                char currentFieldValue = matchfield[xPos, yPos];

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
        public static bool CheckBottomRight(int size, char[,] matchfield, char aktPlayer, char nxtPlayer, int xPos, int yPos)
        {
            bool stoneOfNextPlayerFound = false;
            for (int x = xPos + 1, y = yPos + 1; x >= 0 && x <= size - 1 && y >= 0 && y <= size - 1; x++, y++)
            {
                char currentFieldValue = matchfield[x, y];

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
    }
}
