using Microsoft.AspNetCore.Mvc;

namespace OnlineVotingSystem.Controllers
{
    public class HelloController : Controller
    {
        public String Index(string firstname , string lastname)
        {
            if (lastname != null && firstname != null)
            {
                return "Hello " + firstname + " " + lastname; ;
            }
            else if (firstname == null && lastname != null)
            {
                return "Hello " + lastname;
            }
            else
            {
                return "Hello "+ firstname +" " + lastname;
            }
            //return "Name not defined";
        }
    }
}
