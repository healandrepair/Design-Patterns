namespace Chain_Of_Responsibility;

public class CacheHandler : IHandler
{
    private IHandler next;

    private List<string> cache;
    
    public void SetNext(IHandler handler)
    {
        next = handler;
    }

    public void ExecuteRequest(string request)
    {
        if (cache.Contains(request))
        {
            Console.WriteLine($"Request {request} is aleady in cache.");
        }
        else
        {
            Console.WriteLine("Request is added to cache.");
            cache.Add(request);
        }
        
        if (next == null)
        {
            Console.WriteLine("No next handler. End of chain.");
            return;
        }
        next.ExecuteRequest("cache complete");
    }
}