public interface IObjective
{
    string Name { get; }
    int ID { get; }
    bool IsCompleted { get; }

    public bool CheckIfCompleted()
    {
        return IsCompleted;
    }
}
