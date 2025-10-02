using ConsoleApp1;
using ConsoleApp1.Shared;
using ConsoleApp1.Shared.Controllers;

internal class App
{
    HttpRequest myHttpRequest = new HttpRequest();
    HttpResponse myHttpResponse = new HttpResponse();

    public void createEndPoints()
    {
        UserController.Get("/", myHttpRequest, myHttpResponse);
    }
}