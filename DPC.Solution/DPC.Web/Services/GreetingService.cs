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
