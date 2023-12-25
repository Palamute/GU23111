﻿using System;
using System.Collections.Generic;
using System.Text;

namespace mineText
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] array = {
            {"*", ".", ".", "."},
            {".", ".", ".", "."},
            {".", "*", ".", "."},
            {".", ".", ".", "."}
        };
            int MAP_HEIGHT = array.GetLength(0);
            int MAP_WIDTH = array.GetLength(1);

            string[,] mapReport = new string[MAP_HEIGHT, MAP_WIDTH];
            for (int i = 0; i < MAP_HEIGHT; i++)
            {
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    string curentCell = array[i, j];
                    if (curentCell.Equals("*"))
                    {
                        mapReport[i, j] = "*";
                    }
                    else
                    {
                        int[,] NEIGHBOURS_ORDINATE = {
                        {i - 1, j - 1}, {i - 1, j}, {i - 1, j + 1},
                        {i, j - 1}, {i, j + 1},
                        {i + 1, j - 1}, {i + 1, j}, {i + 1, j + 1},};

                        int minesAround = 0;
                        int length = NEIGHBOURS_ORDINATE.GetLength(0);
                        for (int q = 0; q < length; q++)
                        {
                            int xOrdinateOfNeighbour = NEIGHBOURS_ORDINATE[q, 1];
                            int yOrdinateOfNeighbour = NEIGHBOURS_ORDINATE[q, 0];

                            bool isOutOfMapNeighbour = xOrdinateOfNeighbour < 0
                                    || xOrdinateOfNeighbour == MAP_WIDTH
                                    || yOrdinateOfNeighbour < 0
                                    || yOrdinateOfNeighbour == MAP_HEIGHT;
                            if (isOutOfMapNeighbour)
                            {
                                continue;
                            }

                            bool isMineOwnerNeighbour = array[yOrdinateOfNeighbour, xOrdinateOfNeighbour].Equals("*");
                            if (isMineOwnerNeighbour)
                            {
                                minesAround++;
                            }
                        }

                        mapReport[i, j] = minesAround.ToString();
                    }
                }
            }

            for (int yOrdinate = 0; yOrdinate < MAP_HEIGHT; yOrdinate++)
            {
                Console.WriteLine("\n");
                for (int xOrdinate = 0; xOrdinate < MAP_WIDTH; xOrdinate++)
                {
                    String currentCellReport = mapReport[yOrdinate, xOrdinate];
                    Console.Write(currentCellReport);
                }
            }
            Console.ReadLine();
        }
    }
}