namespace backend.Utils
{
    public class ConversorCliente
    {
        public Models.TbCliente Convert(Models.Request.ClienteRequest cliente)
        {
            Models.TbCliente novo = new Models.TbCliente();

            novo.NmCliente = cliente.nome;
            novo.DsCnh = cliente.cnh;
            novo.DsCpf = cliente.cpf;
            novo.DtNascimento = cliente.nascimento;
            novo.DsRg = cliente.rg;
            novo.DsEndereco = cliente.endereco;
            novo.NrNumero = cliente.numero;
            novo.DsCep = cliente.cep;
            novo.DsComplemento = cliente.complemento;
            
            return novo;
        }

        public Models.Response.ClienteResponse Convert(Models.TbCliente cliente)
        {
            Models.Response.ClienteResponse novo = new Models.Response.ClienteResponse();

            novo.id = cliente.IdCliente;
            novo.nome = cliente.NmCliente;
            novo.cnh = cliente.DsCnh;
            novo.cpf = cliente.DsCpf;
            novo.nascimento = cliente.DtNascimento;
            novo.rg = cliente.DsRg;
            novo.endereco = cliente.DsEndereco;
            novo.numero = cliente.NrNumero;
            novo.cep = cliente.DsCep;
            novo.complemento = cliente.DsComplemento;

            return novo;
        }
    }
}