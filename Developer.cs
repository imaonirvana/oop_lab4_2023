namespace Program;

public class Developer
{
    private readonly EventEmitter _emitter;
    
    public Developer(EventEmitter emitter)
    {
        _emitter = emitter;
        
        _subscribe();
    }

    private void _subscribe()
    {
        _emitter.On("work.received", "Developer", (Event eventData) =>
        {
            Console.WriteLine("dev received task");
            
            _doProject();
        });
    }

    private void _doProject()
    {
        _emitter.DebounceEmit("work.done", new Event(), 1000);
    }
}