namespace Chain_Of_Responsibility;

public interface IHandler
{
    void SetNext(IHandler handler);
    void ExecuteRequest(string request);
}