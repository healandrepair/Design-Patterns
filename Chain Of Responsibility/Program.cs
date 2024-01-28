// See https://aka.ms/new-console-template for more information

/// This code acts as the client.

using Chain_Of_Responsibility;

Console.WriteLine("Hello, World!");

// client instantiates the handlers
IHandler authenticationHandler = new AuthenticationHandler();
IHandler authorizationHandler = new AuthorizationHandler();
IHandler cacheHandler = new CacheHandler();

// client creates the chain, and sets the next handler. Can use a builder o create the chains at runtime.
// WIll fail as is not admin at Authorization handler.
authenticationHandler.SetNext(authorizationHandler);
authorizationHandler.SetNext(cacheHandler);

authenticationHandler.ExecuteRequest("true");


Console.WriteLine("Auth+Authorization handlers");
// Client creates another chain with no cache
IHandler authenticationHandler2 = new AuthenticationHandler();
IHandler authorizationHandler2 = new AuthorizationHandler();

authenticationHandler2.SetNext(authorizationHandler2);
authenticationHandler2.ExecuteRequest("true Admin");


//client only needs authorization, has been authenticated before. 1 handler chain.
Console.WriteLine("Authorization handler only");
IHandler authorizationHandler3 = new AuthorizationHandler();
authorizationHandler3.ExecuteRequest("true Admin");





