namespace DPC.Web.Services
{
    public class GreetingService : IGreetingService
    {
    //intentinally adding a token to see if codeQL finds the token
    //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

        string token = "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";
        string secret = "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";

        string bad_sql = "SELECT * FROM Users WHERE UserId = 105 OR 1=1;";
        public string SayHelloWorld() => "Hello world!";
    }
}
