using System;
using System.Collections.Generic;

namespace Day_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var getInput = true;
            var puzzleInput = new List<string>();

            while (getInput)
            {
                var input = Console.ReadLine();
                if (input == "")
                {
                    getInput = false;
                }
                else
                {
                    puzzleInput.Add(input);
                }
            }

            double totalTrees=0;
            int newTrees = 0;

            newTrees = CalculateTrees(puzzleInput, 1, 1);
            totalTrees = addNewTreesToTotal(newTrees, totalTrees);

            newTrees = CalculateTrees(puzzleInput, 1, 3);
            totalTrees = addNewTreesToTotal(newTrees, totalTrees);

            newTrees = CalculateTrees(puzzleInput, 1, 5);
            totalTrees = addNewTreesToTotal(newTrees, totalTrees);

            newTrees = CalculateTrees(puzzleInput, 1, 7);
            totalTrees = addNewTreesToTotal(newTrees, totalTrees);

            newTrees = CalculateTrees(puzzleInput, 2, 1);
            totalTrees = addNewTreesToTotal(newTrees, totalTrees);


            Console.WriteLine(totalTrees);
        }

        private static double addNewTreesToTotal(int newTrees, double totalTrees)
        {
            if (totalTrees>0&&newTrees>0)
            {
                return totalTrees * newTrees;
            }
            if (totalTrees==0&&newTrees>0)
            {
                return newTrees;
            }
            if (totalTrees>0&&newTrees==0)
            {
                return totalTrees;
            }
            return 0;
        }

        static int CalculateTrees(List<string> puzzleInput,int down,int right)
        {
            int trees = 0;
            int position = right;
            for (int row = down; row < puzzleInput.Count; row=row+down)
            {
                if (position > puzzleInput[row].Length-1)
                {
                    position = position - (puzzleInput[row].Length);
                }
                
                if (puzzleInput[row][position] =='#')
                {
                    trees++;
                }
                position = position + right;
            }

            return trees;
        }
    }
}
