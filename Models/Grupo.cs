using System.Collections.Generic;

namespace ControleStarter.Models
{
    public class Grupo
    {
        public int Id { get; set; }
        public string ScrumMaster { get; set; }
        public Tecnologia Tecnologia { get; set; }
        public List<Starter> Starters { get; set; }
    }
}