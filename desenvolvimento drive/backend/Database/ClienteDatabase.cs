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




   
    }
}