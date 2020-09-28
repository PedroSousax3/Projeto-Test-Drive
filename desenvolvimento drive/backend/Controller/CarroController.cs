using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controller
{
    [ApiController]
    [Route("[Controller]")]
    public class CarroController : ControllerBase
    {
        Utils.ConversorCarro Conversor = new Utils.ConversorCarro();
        Bussiness.CarroBusiness funcaoBusiness = new Bussiness.CarroBusiness();
        [HttpPost]
        public Models.Response.CarroResponse InserirCarro(Models.Request.CarroRequest carro)
        {
            Models.TbCarro novo = Conversor.Convert(carro);
            Models.TbCarro inserido = funcaoBusiness.InserirCarro(novo);
            Models.Response.CarroResponse result = Conversor.Convert(inserido);

            return result;
        }
        [HttpGet]
        public List<Models.Response.CarroResponse> Listar()
        {
            List<Models.TbCarro> carros = funcaoBusiness.ListarBusiness();

            return carros.Select(x => Conversor.Convert(x)).ToList();
        }
        [HttpDelete]
        public Models.Response.CarroResponse DeletarCarro(int idcarro)
        {
            Models.TbCarro removido = funcaoBusiness.DeletarBusiness(idcarro);
            return Conversor.Convert(removido);
        }
        [HttpPut]
        public Models.Response.CarroResponse AlterarCarro(int idcarro, Models.Request.CarroRequest novo)
        {
            Models.TbCarro carro = Conversor.Convert(novo);
            Models.TbCarro alterado = funcaoBusiness.AlterarCarro(idcarro, carro);
            return Conversor.Convert(alterado);
        }
    }
}