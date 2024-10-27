public class SimpleGoal:Goal
{
    private bool _IsComplete;
    public SimpleGoal(string name, string description, string points):base(name,description,points)
    {

    }
    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }
    public override bool IsComplete()
    {
        throw new NotImplementedException();
    }
    public override string GetStringRepresentatino()
    {
        throw new NotImplementedException();
    }
}