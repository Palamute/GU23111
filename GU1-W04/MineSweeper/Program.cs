internal class Program
{
    private static void Main(string[] args)
    {
           string[,] map = { { "*", ".", "*", ".", "." } };
            int MAP_HEIGHT = map.GetLength(0);
            int MAP_WIDTH = map.GetLength(1);

            string[,] mapReport = new string[MAP_HEIGHT, MAP_WIDTH];

            for (int xOrdinate = 0; xOrdinate < map.GetLength(1); xOrdinate++)
            {
                string curentCell = map[0, xOrdinate];
                if (curentCell.Equals("*"))
                {
                    mapReport[0, xOrdinate] = "*";
                }
                else
                {
                    int[,] NEIGHBOURS_ORDINATE = { { 0, xOrdinate - 1 }, { 0, xOrdinate + 1 } };

                    int minesAround = 0;
                    for (int i = 0; i < NEIGHBOURS_ORDINATE.GetLength(0); i++)
                    {
                        int xOrdinateOfNeighbour = NEIGHBOURS_ORDINATE[i, 1];
                        int yOrdinateOfNeighbour = NEIGHBOURS_ORDINATE[i, 0];

                        bool isOutOfMapNeighbour = xOrdinateOfNeighbour < 0 || xOrdinateOfNeighbour == MAP_WIDTH;
                        if (isOutOfMapNeighbour) continue;

                        bool isMineOwnerNeighbour = map[yOrdinateOfNeighbour, xOrdinateOfNeighbour].Equals("*");
                        if (isMineOwnerNeighbour) minesAround++;
                    }

                    mapReport[0, xOrdinate] = minesAround.ToString();
                }
            }

            for (int xOrdinate = 0; xOrdinate < MAP_WIDTH; xOrdinate++)
            {
                String currentCellReport = mapReport[0, xOrdinate];
                Console.Write(currentCellReport);
            }
            
    }
}