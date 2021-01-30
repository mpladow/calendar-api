using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace calendar_api.Controllers
{
    [ApiController]
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Authenticate(string username, string password)
        {
            // authenticate the user and return an auth token
            return null;
        }
        public IActionResult Register(string username, string password)
        {
            // register a username and password
            return null;
        }
    }
}