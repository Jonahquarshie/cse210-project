using System;
using System.IO;

public class GoalsTracker
{
    private List<GoalsTracker> _goals = new List<GoalsTracker>();

    private int _accumulatedPoints = 0;

    public int GetAccumulatedPoints()
    {

        int points = _accumulatedPoints;
        return points;

    }
    public void SaveGoals()
    {
        string fileName = "";
        Console.Write("What is the filename? ");
        fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            int totalAGP = GetAccumulatedPoints();
            outputFile.WriteLine(totalAGP.ToString());

            foreach (GoalsTracker goal in _goals)
            {
                outputFile.WriteLine(goal.Goals());
            }
        }
    }
}