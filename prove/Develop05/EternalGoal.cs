class EternalGoal : Goal
{
    public EternalGoal(string name, int points)
    {
        Name = name;
        Points = points;
    }

    public override int MarkComplete()
    {
        return Points;
    }
}