using Microsoft.AspNetCore.Mvc;

namespace backend.Controller
{
    [ApiController]
    [Route("[Controller]")]
    public class LoginController : ControllerBase
    {
        Bussiness.LoginBusiness funcaoBusiness = new Bussiness.LoginBusiness();
        Utils.LoginConvesor Convesor = new Utils.LoginConvesor();
        
        [HttpPost]
        public Models.Response.LoginResponse Logar(Models.Request.LoginRequest dados)
        {
            Models.TbLogin user = funcaoBusiness.Logar(dados);
            return Convesor.Convert(user);
        }
    }
}