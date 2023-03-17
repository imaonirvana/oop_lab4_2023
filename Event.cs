namespace Program;

public class Event
{
    public readonly DateTime EmitMoment;

    public Event()
    {
        EmitMoment = DateTime.Now;
    }
}