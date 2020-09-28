namespace backend.Utils
{
    public class ConversorCarro
    {
        public Models.TbCarro Convert(Models.Request.CarroRequest carro)
        {
            Models.TbCarro novo = new Models.TbCarro();

            novo.NmModelo = carro.nome;
            novo.BtUsado = carro.usado;
            novo.NmMarca = carro.marca;
            novo.NmModelo = carro.modelo;
            novo.DtFabricao = carro.fabricacao;
            novo.DtModelo = carro.lancamento_modelo;
            novo.NrKm = carro.km;
            novo.DsCor = carro.cor;
            novo.BtArcondicionado = carro.arcondicaionado;
            novo.DsCarro = carro.descricao;
            novo.VlPreco = carro.valor;

            return novo;
        }
        public Models.Response.CarroResponse Convert(Models.TbCarro carro)
        {
            Models.Response.CarroResponse novo = new Models.Response.CarroResponse();

            novo.nome = carro.NmModelo; 
            novo.usado = carro.BtUsado;
            novo.marca = carro.NmMarca;
            novo.modelo = carro.NmModelo;
            novo.fabricacao = carro.DtFabricao;
            novo.lancamento_modelo = carro.DtModelo;
            novo.km = carro.NrKm;
            novo.cor = carro.DsCor;
            novo.arcondicaionado = carro.BtArcondicionado;
            novo.descricao = carro.DsCarro;
            novo.valor = carro.VlPreco;

            return novo;
        }
    }
}