using System;

namespace backend.Models.Response
{
    public class ClienteResponse
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string cnh { get; set; }
        public string cpf { get; set; }
        public DateTime nascimento { get; set; }
        public string rg { get; set; }
        public string endereco { get; set; }
        public int numero { get; set; }
        public string cep { get; set; }
        public string complemento { get; set; }
    }
}