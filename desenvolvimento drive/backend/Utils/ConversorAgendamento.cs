namespace backend.Utils
{
    public class ConversorAgendamento
    {
        public Models.TbAgendamento Convert(Models.Request.AgendarRequest dados)
        {
            Models.TbAgendamento agendamento = new Models.TbAgendamento();

            agendamento.IdCarro = dados.carro;
            agendamento.IdCliente = dados.cliente;
            agendamento.IdFuncionario = dados.funcionario;
            agendamento.DtAgendamento = dados.data;
            agendamento.HrInicio = dados.inicio;
            agendamento.HrFim = dados.fim;
            agendamento.DsStatus = dados.status;
            agendamento.DsAgendamento =  dados.observacao;

            return agendamento;
        }

        public Models.Response.AgendaResponse Convert(Models.TbAgendamento dados)
        {
            Models.Response.AgendaResponse agendamento = new Models.Response.AgendaResponse();

            agendamento.id = dados.IdAgendamento;
            agendamento.carro = dados.IdCarroNavigation.NmModelo;
            agendamento.data = dados.DtAgendamento;
            agendamento.inicio = dados.HrInicio;
            agendamento.fim = dados.HrFim;
            agendamento.status = dados.DsStatus;
            agendamento.observacao = dados.DsAgendamento;

            return agendamento;
        }
    }
}