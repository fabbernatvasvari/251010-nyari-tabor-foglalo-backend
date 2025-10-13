using ConsoleApp1.Shared;
namespace ConsoleApp1
{
    public class HttpRequest
    {
        private string _myHttpRequest = null;
        
        public HttpBody Body = new HttpBody();
       
        private Params Parameters = new Params();
        public HttpRequest() {
          
        }   
        
        public string MyHttpRequest { get => _myHttpRequest; set => _myHttpRequest = value; }
    }
}