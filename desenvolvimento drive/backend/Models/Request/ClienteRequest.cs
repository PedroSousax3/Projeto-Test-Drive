using System;

namespace backend.Models.Request
{
    public class ClienteRequest
    {
        public string nome { get; set; }
        public string cnh { get; set; }
        public string cpf { get; set; }
        public string rg { get; set; }
        public DateTime nascimento { get; set; }
        public string email { get; set; }        
        public string celular { get; set; }
        public string endereco { get; set; }
        public int numero { get; set; }
        public string cep { get; set; }
        public string complemento { get; set; }
    }
}