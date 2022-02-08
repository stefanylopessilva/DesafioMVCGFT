namespace ControleStarter.Models
{
    public class Starter
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string QuatroLetras { get; set; }
        public Tecnologia Tecnologia { get; set; }
        public Grupo Grupo { get; set; }
        public ProgramaStart ProgramaStart { get; set; }
        public Modulo Modulo { get; set; }
    }
}