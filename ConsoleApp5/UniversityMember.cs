namespace ConsoleApp5;

public class UniversityMember
{
    private string _name;

    public string Name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(value));
    }
    
    public string MemberId { get; }

    protected List<string> ActionLog;

    public UniversityMember(string name, string id)
    {
        Name = name;
        MemberId = id;
    }

    public virtual void PerformDuties()
    {
        if (ActionLog.Count > 5)
        {
            Console.WriteLine("Limit is reached");
        }
    }

    public int ActionCount()
    {
        return ActionLog.Count;
    }
}