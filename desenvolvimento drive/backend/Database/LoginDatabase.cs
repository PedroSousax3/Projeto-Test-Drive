using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace backend.Database
{
    public class LoginDatabase
    {
        Models.teste_driveContext bd = new Models.teste_driveContext();
        public Models.TbLogin ConsultarLogin(Models.Request.LoginRequest user)
        {
            return (
                bd.TbLogin.Include(x => x.IdClienteNavigation).Include(x => x.IdFuncionarioNavigation)
                        .FirstOrDefault(x => x.DsEmail == user.usuario 
                                            && x.DsEmail == user.senha)
            );
        }
    }
}