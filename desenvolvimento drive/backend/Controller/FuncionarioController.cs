using Microsoft.AspNetCore.Mvc;

namespace backend.Controller
{
    [ApiController]
    [Route("[Controller]")]
    public class FuncionarioController : ControllerBase
    {
        Bussiness.FuncionarioBusiness funcaoBusiness = new Bussiness.FuncionarioBusiness();
        Utils.FuncionarioConvesor Convesor = new Utils.FuncionarioConvesor();
        
        [HttpPost]
        public Models.Response.FuncionarioResponse Alterar (Models.Request.FuncionarioRequest dados)
        {
            Models.TbFuncionario user = funcaoBusiness.Alterar (dados);
            return Convesor.Convert(user);
        }
        
        [HttpGet]
        public List<Models.Response.FuncionarioResponse> Listar()
        {
            List<Models.TbFuncionario> funcionarios = funcaoBusiness.ListarBusiness();


            return funcionarios.Select(x => Conversor.Convert(x)).ToList();
        }
        [HttpDelete]
        public Models.Response.FuncionarioResponse DeletarFuncionario(int idfuncionario)
        {
            Models.TbFuncionario removido = funcaoBusiness.DeletarBusiness(idfuncionario);
            return Conversor.Convert(removido);
        }
        [HttpPut]
        public Models.Response.FuncionarioResponse AlterarFuncionario(int idFuncionario, Models.Request.FuncionarioRequest novo)
        {
            Models.TbFuncionario funcionario = Conversor.Convert(novo);
            Models.TbFuncionario alterado = funcaoBusiness.AlterarFuncionario(idfuncionario, funcionario);
            return Conversor.Convert(alterado);
        }
    }
}
    
