using System;

public sealed class Authenticator
{
    private static readonly object _lock = new object();
    private static Authenticator _instance;

    public string Token { get; private set; }

    private Authenticator()
    {
        Token = Guid.NewGuid().ToString();
    }

    public static Authenticator Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Authenticator();
                    }
                }
            }
            return _instance;
        }
    }
}
