using System.Collections.Generic;
using System.Linq;

namespace backend.Database
{
    public class ClienteDatabase
    {
        Models.teste_driveContext bd = new Models.teste_driveContext();
        public Models.TbCliente InserirCliente(Models.TbCliente cliente)
        {
            bd.Add(cliente);
            bd.SaveChanges();

            return cliente;
        }

        public List<Models.TbCliente> ListarClientes()
        {
            return bd.TbCliente.ToList();
        }

    
         public Models.TbCliente DeletarCliente(int idClinte)
        {
            Models.TbCliente Cliente = this.Consultar(idClinte);
            bd.Remove(Cliente);
            bd.SaveChanges();
            return Cliente;
        }

        public Models.TbCliente Alterar(int idCliente, Models.TbCliente novo)
        {
            Models.TbCliente Cliente = this.ConsultarPorId(idCliente);

           Cliente.IdCliente = novo.IdCliente;
           Cliente.NmCliente = novo.NmCliente;
            Cliente.DtCliente = novo.DtCliente;
            Cliente.HrInicio = novo.HrInicio;
            Cliente.HrFim = novo.HrFim;
            Cliente.DsStatus = novo.DsStatus;
            Cliente.DsCliente = novo.DsCliente;

            return Cliente;
        }


   
    }
}