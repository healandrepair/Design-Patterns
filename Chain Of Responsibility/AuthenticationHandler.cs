namespace Chain_Of_Responsibility;

public class AuthenticationHandler : IHandler
{
    private IHandler next;
    
    public void SetNext(IHandler handler)
    {
        next = handler;
    }

    public void ExecuteRequest(string request)
    {
        if (request.Contains("false"))
        {
            Console.WriteLine("Exiting authentication handler, request is invalid.");
            Console.WriteLine("exit chain.");
        }
        else
        {
            Console.WriteLine("Authentication passed. Going to next handler.");
            if (next == null)
            {
                Console.WriteLine("No next handler. End of chain.");
                return;
            }
            next.ExecuteRequest(request);
        }
    }
}