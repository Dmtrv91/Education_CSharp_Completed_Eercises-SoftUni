using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ConsoleAppGlava16Exercises16

//Използвайки опашка, реализирайте пълно обхождане на всички директории на твърдия ви диск и ги отпечатвайте на конзолата.
//Реализирайте алгоритъма "обхождане в ширина" – Breadth-First-Search(BFS) – може да намерите стотици статии за него в Интернет.

{
    class Program
    {
       static string[,] labyrinth =
       {
          { "0", "0", "0", "x", "0", "x" },
          { "0", "x", "0", "x", "0", "x" },
          { "0", "*", "x", "0", "x", "0" },
          { "0", "x", "0", "0", "0", "0" },
          { "0", "0", "0", "x", "x", "0" },
          { "0", "0", "0", "x", "0", "x" }
       };

            static Cell initialCell = null;

            static void Main()
            {
                Queue<Cell> visitedCells = new Queue<Cell>();

                FindStartingCell();
                PrintLabyrinth();

                VisitCell(visitedCells, initialCell.Row, initialCell.Col, 0);
                while (visitedCells.Count > 0)
                {
                    Cell currentCell = visitedCells.Dequeue();
                    int row = currentCell.Row;
                    int col = currentCell.Col;
                    int distance = currentCell.Distance;

                    if (row == 0 || row == labyrinth.GetLongLength(0) - 1 ||
                        col == 0 || col == labyrinth.GetLongLength(1) - 1)
                    {
                        PrintLabyrinth();
                        Console.WriteLine("The shortest way is: {0}\n", distance + 1);
                        break;
                    }

                    VisitCell(visitedCells, row, col + 1, distance + 1);
                    VisitCell(visitedCells, row, col - 1, distance + 1);
                    VisitCell(visitedCells, row + 1, col, distance + 1);
                    VisitCell(visitedCells, row - 1, col, distance + 1);
                }
            }

            static void FindStartingCell()
            {
                for (int i = 0; i < labyrinth.GetLongLength(0); i++)
                {
                    for (int j = 0; j < labyrinth.GetLongLength(1); j++)
                    {
                        if (labyrinth[i, j] == "*")
                        {
                            initialCell = new Cell(i, j, 0);
                            return;
                        }
                    }
                }
                throw new Exception("Start cell is missing -> no path...\n");
            }

            static void VisitCell(Queue<Cell> visitedCells, int row, int col, int distance)
            {
                if (labyrinth[row, col] != "x")
                {
                    labyrinth[row, col] = "x";
                    visitedCells.Enqueue(new Cell(row, col, distance));
                }
            }

            static void PrintLabyrinth()
            {
                for (int i = 0; i < labyrinth.GetLongLength(0); i++)
                {
                    for (int j = 0; j < labyrinth.GetLongLength(1); j++)
                        Console.Write("{0,3}", labyrinth[i, j]);
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            public class Cell
            {
                public Cell(int row, int col, int distance)
                {
                    this.Row = row;
                    this.Col = col;
                    this.Distance = distance;
                }

                public int Row { get; set; }
                public int Col { get; set; }
                public int Distance { get; set; }
            }
        }
    }
}

