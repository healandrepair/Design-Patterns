namespace Chain_Of_Responsibility;

public class AuthorizationHandler : IHandler
{
    private IHandler next;
    public void SetNext(IHandler handler)
    {
        next = handler;
    }

    public void ExecuteRequest(string request)
    {
        if (request.Contains("Admin"))
        {
            Console.WriteLine("Successfully Authorized");
            if (next == null)
            {
                Console.WriteLine("No next handler. End of chain.");
                return;
            }
            next.ExecuteRequest(request);
        }
        else
        {
            Console.WriteLine("Failed Authorization. Is not admin");
            Console.WriteLine("exit chain.");
        }
    }
}