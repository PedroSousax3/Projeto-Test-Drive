using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace backend.Database
{
    public class AgendarDatabase
    {
        Models.teste_driveContext bd = new Models.teste_driveContext();

        public Models.TbAgendamento CadastrarAgendamento(Models.TbAgendamento dados)
        {
            bd.Add(dados);
            bd.SaveChanges();

            return dados;
        }

        public List<Models.TbAgendamento> Listar()
        {
            return bd.TbAgendamento.ToList();
        }

        public List<Models.TbAgendamento> ListarPorCliente(int idcliente)
        {
            return this.Listar()
                       .Where(x => x.IdCliente == idcliente)
                       .ToList();
        }

        public Models.TbAgendamento ConsultarPorId(int idagendamento)
        {
            List<Models.TbAgendamento> agendamentos = this.Listar();
            return agendamentos.FirstOrDefault(x => x.IdAgendamento == idagendamento);
        }

        public Models.TbAgendamento Alterar(int idagendamento, Models.TbAgendamento novo)
        {
            Models.TbAgendamento agendamento = this.ConsultarPorId(idagendamento);

            agendamento.IdAgendamento = novo.IdAgendamento;
            agendamento.IdCarroNavigation.NmModelo = novo.IdCarroNavigation.NmModelo;
            agendamento.DtAgendamento = novo.DtAgendamento;
            agendamento.HrInicio = novo.HrInicio;
            agendamento.HrFim = novo.HrFim;
            agendamento.DsStatus = novo.DsStatus;
            agendamento.DsAgendamento = novo.DsAgendamento;

            return agendamento;
        }

        public Models.TbAgendamento RemoverPorId(int idagendamento)
        {
            Models.TbAgendamento agendamento = this.ConsultarPorId(idagendamento);
            bd.Remove(agendamento);
            bd.SaveChanges();
            return agendamento;
        }
    }
}