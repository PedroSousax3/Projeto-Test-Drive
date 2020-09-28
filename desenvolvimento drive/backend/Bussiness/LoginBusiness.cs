using System;

namespace backend.Bussiness
{
    public class LoginBusiness
    {
        Database.LoginDatabase funcaoDatabase = new Database.LoginDatabase();
        public Models.TbLogin Logar(Models.Request.LoginRequest user)
        {
            if(string.IsNullOrEmpty(user.usuario))
                throw new ArgumentException("Usuario não informado.");
                
            if(string.IsNullOrEmpty(user.senha))
                throw new ArgumentException("Senha não informada.");

            return funcaoDatabase.ConsultarLogin(user);
        }
    }
}