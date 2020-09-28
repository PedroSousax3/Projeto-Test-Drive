using Microsoft.AspNetCore.Mvc;

namespace backend.Controller
{
    [ApiController]
    [Route("[Controller]")]
    public class ClienteController : ControllerBase
    {
       Utils.ConversorCliente Conversor = new Utils.ConversorCliente();
       Bussiness.ClienteBusiness funcaoBusiness = new Bussiness.ClienteBusiness();

       [httpPost]
        public Models.Response.ClienteResponse Inserir ()
        {
            Models.TbCliente user = funcaoBusiness.Inserir(dados);
            return Convesor.Convert(user);
        }
        
        [httpGet]
         public Models.Response.ClienteResponse Consultar(string cpf)
        {
            List<Models.TbCliente> cliente = funcaoBusiness. ConsultarBusiness();

            return cliente.Select(x => Conversor.Convert(x)).ToList();
        }

        [httpGet]
        public List<Models.Response.ClienteResponse> Listar()
        {
            List<Models.TbCarro> Cliente = funcaoBusiness.ListarBusiness();

            return cliente.Select(x => Conversor.Convert(x)).ToList();
        }


        [httpDelete]
        public Models.Response.ClienteResponse DeletarCliente (int idCliente)
        {
            Models.TbCliente removido = funcaoBusiness.DeletarClienteBusiness(idCliente);
            return Conversor.Convert(removido);
        }

        [httpPut]
        public Models.Response.LoginResponse AlterarCliente (int idCliente, Models.Request.ClienteRequest novo)
        {
            Models.TbCliente Cliente = Conversor.Convert(novo);
            Models.TbCarro alterado = funcaoBusiness.AlterarCliente(idlogin, login);
            return Conversor.Convert(AlterarCliente);
        }  
    }

}
