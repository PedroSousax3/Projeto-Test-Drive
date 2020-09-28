using System;

namespace backend.Models.Response
{
    public class AgendaResponse
    {
        public int id { get; set; }
        public string carro { get; set; }
        public DateTime data { get; set; }
        public TimeSpan inicio { get; set; }
        public TimeSpan fim { get; set; }
        public string status { get; set; }
        public string observacao { get; set; }
    }
}