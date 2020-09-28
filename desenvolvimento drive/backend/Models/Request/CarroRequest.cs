using System;

namespace backend.Models.Request
{
    public class CarroRequest
    {
        public string nome { get; set; }
        public bool usado { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public DateTime? fabricacao { get; set; }
        public DateTime lancamento_modelo { get; set; }
        public int? km { get; set; }
        public string cor { get; set; }
        public bool arcondicaionado { get; set; }
        public string descricao { get; set; }
        public decimal valor { get; set; }
    }
}