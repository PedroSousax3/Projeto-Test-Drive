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

        [httpGet]
        
        public public List<Models.Response.LoginResponse> Listar()
        {
            List<Models.TbLogin> login = funcaoBusiness.ListarBusiness();

            return login.Select(x => Conversor.Convert(x)).ToList();
        }

        [httpDelete]

        public  Models.Response.LoginResponse DeletarLogin(int idlogin)
        {
            Models.TbLogin removido = funcaoBusiness.DeletarBusiness(idlogin);
            return Conversor.Convert(removido);
        }

        [httpPut]

        public  Models.Response.LoginResponse AlterarLogin(int idlogin, Models.Request.LoginRequest novo)
        {
            Models.TbLogin login = Conversor.Convert(novo);
            Models.TbLogin alterado = funcaoBusiness.AlterarLogin(idlogin, login);
            return Conversor.Convert(AlterarLogin);
        }
    }
}