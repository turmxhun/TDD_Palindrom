using System;

public class NemMegfeleloParameterException : Exception
{
    public NemMegfeleloParameterException() : base("A paraméter nem megfelelő.")
    {
    }

    public NemMegfeleloParameterException(string message) : base(message)
    {
    }

    public NemMegfeleloParameterException(string message, Exception innerException) : base(message, innerException)
    {
    }
}
