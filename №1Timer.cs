class Timer
{
    private readonly TimerAction _action;
    private readonly int _interval;
    private bool _running;
    private Thread _thread;

    public Timer(TimerAction action, int intervalSeconds)
    {
        if (action == null)
        {
            throw new ArgumentNullException(nameof(action));
        }
        _action = action;
        _interval = intervalSeconds * 1000;
    }

    public void Start()
    {
        if (_running) return;
        _running = true;
        _thread = new Thread(Run) { IsBackground = true };
        _thread.Start();
    }

    public void Stop()
    {
        _running = false;
    }

    private void Run()
    {
        while (_running)
        {
            _action.Invoke();
            Thread.Sleep(_interval);
        }
    }
}
