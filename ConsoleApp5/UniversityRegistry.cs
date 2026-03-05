namespace ConsoleApp5;

public class UniversityRegistry
{
    private List<UniversityMember> _members = new List<UniversityMember>();
    public void AddMember(UniversityMember m) => _members.Add(m);

    public void ExecuteAllDuties()
    {
        foreach (var member in _members)
        {
            member.PerformDuties();
        }
    }

    public void GetMemberStatistics()
    {
        int actions = 0;
        foreach (var member in _members)
        {
            actions += member.ActionCount();
        }
    }
    
}