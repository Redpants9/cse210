public class EternalGoal:Goal
{
    public EternalGoal(string name, string description, string points):base(name, description, points)
    {

    }
    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresentatino()
    {
        throw new NotImplementedException();
    }
}