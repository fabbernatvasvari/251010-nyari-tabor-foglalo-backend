using ConsoleApp1.Shared;
namespace ConsoleApp1
{
    public class HttpRequest
    {
        private string _myHttpRequest = null;
        
        HttpBody Body = new HttpBody();
        public HttpRequest() {
            Params Params = new Params();
        }   
        
        public string MyHttpRequest { get => _myHttpRequest; set => _myHttpRequest = value; }
        
    }
}