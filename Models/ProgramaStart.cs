using System;

namespace ControleStarter.Models
{
    public class ProgramaStart
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
    }
}