namespace backend.Utils
{
    public class LoginConvesor
    {
        public Models.Response.LoginResponse Convert (Models.TbLogin user)
        {
            Models.Response.LoginResponse result = new Models.Response.LoginResponse();

            result.usuario = user.DsEmail;
            if(user.IdClienteNavigation.IdCliente > 1) 
                result.cargo = "cliente";
            else 
            {
                result.cargo = user.IdFuncionarioNavigation.NmCargo;
            }

            return result;
        }
    }
}