using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class ProfilController : Controller
    {
        public String Index()
        {
            UserModel Model = new UserModel();
            Model.FirstName = "Imane";
            Model.LastName = "El Idrissi";
            Model.Email = "ielidrissi2@gmail.com";
            return Model.FirstName+  " "+ Model.LastName +" " + Model.Email;
                
        }
    }
}
