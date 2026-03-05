namespace ConsoleApp5;

public class Professor : UniversityMember
{
    public Professor(string name, string id) : base(name, id){ }
    public override void PerformDuties()
    {
        base.PerformDuties();
        ActionLog.Add("Lecture delivered");
        
    }
    public void ConductResearch(string topic)
    {
        ActionLog.Add(topic);
    }
    
}