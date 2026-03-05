namespace ConsoleApp5;

public class UndergraduateStudent : UniversityMember
{
    public UndergraduateStudent(string name, string id) : base(name, id){ }
    public override void PerformDuties()
    {
        base.PerformDuties();
        ActionLog.Add("Lab work completed");
    }
    
}