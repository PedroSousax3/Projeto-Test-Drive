using System.Collections.Generic;
using System.Linq;

namespace backend.Database
{
    public class FuncionarioDatabase
    {
        Models.teste_driveContext bd = new Models.teste_driveContext();
        public Models.TbFuncionario AlterarFuncionario(Models.TbFuncionario  funcionario)
        {
            bd.Add(funcionario);
            bd.SaveChanges();

            return funcionario;
        }

        public List<Models.TbFuncionario> ListarFuncionario()
        {
            return bd.TbFuncionario.ToList();
        }       
    }
}