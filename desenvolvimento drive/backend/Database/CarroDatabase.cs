using System.Linq;
using System.Collections.Generic;

namespace backend.Database
{
    public class CarroDatabase
    {
        Models.teste_driveContext bd = new Models.teste_driveContext();
        public Models.TbCarro InserirCarro (Models.TbCarro carro)
        {
            bd.Add(carro);
            bd.SaveChanges();

            return carro;
        }
        
        public List<Models.TbCarro> Listar ()
        {
            return bd.TbCarro.ToList();
        }

        public Models.TbCarro DeletarCarro(int carro)
        {
            Models.TbCarro result = bd.TbCarro.FirstOrDefault(x => x.IdCarro == carro);
            bd.Remove(result);
            bd.SaveChanges();
            return result;
        }

        public Models.TbCarro AlterarCarro (int idcarro, Models.TbCarro carro)
        {
            Models.TbCarro novo = bd.TbCarro.FirstOrDefault(x => x.IdCarro == idcarro);
            
            novo.NmModelo = carro.NmModelo;
            novo.BtUsado = carro.BtUsado;
            novo.NmMarca = carro.NmMarca;
            novo.NmModelo = carro.NmModelo;
            novo.DtFabricao = carro.DtFabricao;
            novo.DtModelo = carro.DtModelo;
            novo.NrKm = carro.NrKm;
            novo.DsCor = carro.DsCor;
            novo.BtArcondicionado = carro.BtArcondicionado;
            novo.DsCarro = carro.DsCarro;
            novo.VlPreco = carro.VlPreco;

            bd.SaveChanges();
            return novo;
        }
    }
}