using System;

namespace ControleStarter.Models
{
    public class Daily
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Fazendo { get; set; }
        public string Feito { get; set; }
        public string Impedimentos { get; set; }
        public int Presenca { get; set; }
        public Grupo Grupo { get; set; }
        public Modulo Modulo { get; set; }
        public Starter Starter { get; set; }
    }
}