using ConsoleApp1.Shared.Models;
using System.Collections;
using System.Collections.Generic;
using Thunder.Web;

namespace ConsoleApp1.Shared.Controllers
{
    internal class UserController
    {
        private List<User> users;

        public UserController()
        {
            users = new List<User>()
            {
                new User("Alice", 30, "alice@gmail.com", "alice"),
                new User(  "Bob", 17, "bob@gmail.com",  "bob"),
                new User("kutya", 6, "kutya@gmail.com",  "kutya"),
                new User(  "allat", 3, "allat@gmail.com",  "allat"),
            };
        }

        public UserController(List<User> users) => this.users = users;

        public List<User> Users { get => users; set => users = value; }

        public void Add(User user)
        {
            users.Add(user);
        }

        // GET
        public static void Get(string endPoint, HttpRequest req, HttpResponse res)
        {
            if (endPoint == "/")
            {
                res.Status = 200;
                res.Send("<h1>Hello World!</h1><a href='/users'>Go to users</a>");
            }
            else if (endPoint == "/users")
            {
                res.Status = 200;
                res.Json();
            }
            else if (endPoint == "/users/:id")
            {
                try
                {

                }
                catch (Exception nfe)
                {
                    Console.Error.WriteLine("Illegal number format:" + nfe);
                }

                res.Status = 200;
                res.Json();
            }
            else
            {
                res.Status = 404;
            }
        }

        // POST
        public static void Post(string endPoint, HttpRequest req, HttpResponse res)
        {
            if (endPoint == "/users")
            {
                if (req.Body.Name == null || req.Body.Age == null || req.Body.Email == null || req.Body.Password == null)
                {
                    res.Status = 400;
                    res.Send("Missing required fields");
                    return;
                }
                User newUser = new User(req.Body.Name, req.Body.Age, req.Body.Email, req.Body.Password);

                res.Status = 201;
                res.Json();
            }
        }

        // PUT
        public static void Put(string endPoint, HttpRequest req, HttpResponse res) { }
    }
}
        