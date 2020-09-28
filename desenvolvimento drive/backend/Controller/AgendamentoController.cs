using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controller
{
    [ApiController]
    [Route("[Controller]")]
    public class AgendamentoController : ControllerBase
    {
        Utils.ConversorAgendamento Conversor = new Utils.ConversorAgendamento();
        Bussiness.AgendaBusiness funcaoBusiness = new Bussiness.AgendaBusiness();

        [HttpPost]
        public ActionResult<Models.Response.AgendaResponse> AgendarController(Models.Request.AgendarRequest dados)
        {
            try
            {
                Models.TbAgendamento agendamento = Conversor.Convert(dados);
                Models.TbAgendamento inserido = funcaoBusiness.CadastrarAgendamento(agendamento);
                Models.Response.AgendaResponse result = Conversor.Convert(inserido);

                return result;
            }
            catch (System.Exception ex)
            {
                return BadRequest(
                    new Models.Response.ErroResponse(404, ex.Message)
                );
            }
        }

        [HttpGet]
        public ActionResult<List<Models.Response.AgendaResponse>> ListarController()
        {
            try
            {
                List<Models.TbAgendamento> consulta = funcaoBusiness.ListarAgendamentos();
                return consulta.Select(x => Conversor.Convert(x)).ToList();   
            }
            catch (System.Exception ex)
            {
                return BadRequest(
                    new Models.Response.ErroResponse(400, ex.Message)
                );
            }
        }

        public ActionResult<List<Models.Response.AgendaResponse>> ListarAgendamentos(int idcliente)
        {
            try
            {
                List<Models.TbAgendamento> agendamentos = funcaoBusiness.ListarAgendamentos(idcliente);
                List<Models.Response.AgendaResponse> result =  agendamentos.Select(x => Conversor.Convert(x)).ToList();

                return result;
            }
            catch (System.Exception ex)
            {
                return BadRequest(
                    new Models.Response.ErroResponse(404, ex.Message)
                );
            }
        }

        [HttpPut]
        public ActionResult<Models.Response.AgendaResponse> AlterarController(int idagendamento, Models.Request.AgendarRequest novo)
        {
            try
            {
                Models.TbAgendamento agendamento = Conversor.Convert(novo);
                Models.TbAgendamento alterado = funcaoBusiness.AlterarAgendamentos(idagendamento, agendamento);
                return Conversor.Convert(alterado);                
            }
            catch(System.Exception ex)
            {
                return BadRequest(
                    new Models.Response.ErroResponse(404, ex.Message)
                );
            }

        }

        [HttpDelete]
        public Models.Response.AgendaResponse RemoverController(int idagendamento)
        {
            Models.TbAgendamento removido = funcaoBusiness.RemoverAgendamentos(idagendamento);
            Models.Response.AgendaResponse result = Conversor.Convert(removido);

            return result;
        }
    }
}