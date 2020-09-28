using System;
using System.Collections.Generic;

namespace backend.Bussiness
{
    public class FuncionarioBusiness
    {
        Database.FuncionarioDatabase funcaoDatabase = new Database.FuncionarioDatabase();
        public Models.TbFuncionario CadastrarFuncionario(Models.TbFuncionario dados)
        {
            if (dados.DtFuncionario < DateTime.Now)
                throw new ArgumentException("Data não pode ser menor que data atual.");

            return funcaoDatabase.CadastrarFuncionario(dados);   
        }

        public List<Models.TbFuncionario> ListarFuncionario()
        {
            return funcaoDatabase.Listar();
        }

        public List<Models.TbFuncionario> ListarFuncionario(int idcliente)
        {
            if(idcliente <= 0)
                throw new ArgumentException("Campo id não foi inserido.");
            
            return funcaoDatabase.ListarPorCliente(idcliente);
        }

        public Models.TbFuncionario ConsultarFuncionario(int idfuncionario)
        {
            if(idfuncionario <= 0)
                throw new ArgumentException("Campo id não foi inserido.");
            
            return funcaoDatabase.ConsultarFuncionario(idfuncionario);
        }

        public Models.TbFuncionario AlterarFuncionario(int idfuncionario, Models.TbFuncionario funcionario)
        {
            if(idfuncionario <= 0)
             throw new ArgumentException("Id do funcionario não foi informado.");

            return funcaoDatabase.Alterar(idfuncionario,funcionario);
        }

        public Models.TbFuncionario RemoverFuncionario(int idfuncionario)
        {
            if(idfuncionario <= 0)
                throw new ArgumentException("Campo id não foi inserido.");
            
            return funcaoDatabase.RemoverPorId(idfuncionario);
        } 
    }
}