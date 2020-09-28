using System;
using System.Collections.Generic;

namespace backend.Bussiness
{
    public class CarroBusiness
    {
        Database.CarroDatabase funcaoDatabase = new Database.CarroDatabase();
        public Models.TbCarro InserirCarro(Models.TbCarro novo)
        {
            if(string.IsNullOrEmpty(novo.NmModelo))
                new ArgumentException("Campo nome do modelo não foi preenchido.");
                
            return funcaoDatabase.InserirCarro(novo);
        }

        public List<Models.TbCarro> ListarBusiness()
        {
            return funcaoDatabase.Listar();
        }

        public Models.TbCarro AlterarCarro(int idcarro, Models.TbCarro carro)
        {
            if(idcarro <= 0)
             throw new ArgumentException("Campo idcarro não foi inserido");
            
            return funcaoDatabase.AlterarCarro(idcarro, carro);
        }

        public Models.TbCarro DeletarBusiness(int idcarro)
        {
            if(idcarro <= 0)
                throw new ArgumentException("Campo idcarro não foi inserido");
            
            return funcaoDatabase.DeletarCarro(idcarro);
        }
    }
}