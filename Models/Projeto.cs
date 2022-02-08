namespace ControleStarter.Models
{
    public class Projeto
    {
        public int Id { get; set; }
        public string Avaliacao { get; set; }
        public Modulo Modulo { get; set ;}
        public Starter Starter { get; set; }
    }
}