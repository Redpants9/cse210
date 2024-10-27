public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    GoalManager()
    {
        Console.WriteLine($"{_score}:points");
        foreach(Goal goal in _goals)
        {
            Console.WriteLine(goal);
        }
    }
    static void Start()
    {
        Console.WriteLine("Please select from the following choices:");
        Console.WriteLine("1.Create Goal");
        Console.WriteLine("2.List Goals");
        Console.WriteLine("3.Save Goals");
        Console.WriteLine("4.Load Goals");
        Console.WriteLine("5.Record Event");
        Console.WriteLine("6.Quit");
        Console.Write("What would you like to do? ");
        string response = Console.ReadLine();
    }
    static void DisplayPlayerInfo()
    {

    }
    static void ListGoalNames()
    {

    }
    static void ListGoalDetails()
    {

    }
    static void CreateGoal()
    {

    }
    static void RecordEvent()
    {

    }
    static void SaveGoals()
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry e in entries)
            {
                outputFile.WriteLine($"{e.date},{e.promptText},{e.entryText}");
            }
        }
    }
    static void LoadGoals()
    {
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            Entry _entry = new Entry();
            _entry.date = parts[0];
            _entry.promptText = parts[1];
            _entry.entryText = parts[2];
            addentry(_entry);
        }
    }


}