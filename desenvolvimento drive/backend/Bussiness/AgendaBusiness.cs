using System;
using System.Collections.Generic;

namespace backend.Bussiness
{
    public class AgendaBusiness
    {
        Database.AgendarDatabase funcaoDatabase = new Database.AgendarDatabase();
        public Models.TbAgendamento CadastrarAgendamento(Models.TbAgendamento dados)
        {
            if(dados.DtAgendamento < DateTime.Now)
                throw new ArgumentException("Data não pode ser menor que data atual.");

            return funcaoDatabase.CadastrarAgendamento(dados);   
        }

        public List<Models.TbAgendamento> ListarAgendamentos()
        {
            return funcaoDatabase.Listar();
        }

        public List<Models.TbAgendamento> ListarAgendamentoPorId(int idcliente)
        {
            if(idcliente <= 0)
                throw new ArgumentException("Campo id não foi inserido.");
            
            return funcaoDatabase.ListarPorCliente(idcliente);
        }

        public Models.TbAgendamento ConsultarAgendamentoPorId(int idagendamento)
        {
            if(idagendamento <= 0)
                throw new ArgumentException("Campo id não foi inserido.");
            
            return funcaoDatabase.ConsultarPorId(idagendamento);
        }

        public Models.TbAgendamento AlterarAgendamentoPorId(int idagendamento, Models.TbAgendamento agendamento)
        {
            if(idagendamento <= 0)
             throw new ArgumentException("Id do agendamento não foi informado.");

            return funcaoDatabase.Alterar(idagendamento, agendamento);
        }

        public Models.TbAgendamento RemoverAgendamentoPorId(int idagendamento)
        {
            if(idagendamento <= 0)
                throw new ArgumentException("Campo id não foi inserido.");
            
            return funcaoDatabase.RemoverPorId(idagendamento);
        } 
    }
}