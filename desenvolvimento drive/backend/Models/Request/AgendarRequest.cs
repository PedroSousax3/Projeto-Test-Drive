using System;

namespace backend.Models.Request
{
    public class AgendarRequest
    {
        public int carro { get; set; }
        public int cliente { get; set; }
        public int funcionario { get; set; }
        public DateTime data { get; set; }
        public TimeSpan inicio { get; set; }
        public TimeSpan fim { get; set; }
        public string status { get; set; }
        public string observacao { get; set; }
    }
}