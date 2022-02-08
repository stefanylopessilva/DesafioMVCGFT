using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ControleStarter.DTO
{
    public class GrupoDTO
    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage="Scrum Master é um item obrigatório")]
        [StringLength(100, ErrorMessage = "Nome do Scrum Master excede ao tamanho, tente um nome com menos caracteres.")]
        [MinLength(2, ErrorMessage = "Nome do Scrum Master  menor que tamanho requerido, tente um nome com mais caracteres.")]
        public string ScrumMaster { get; set; }
        [Required(ErrorMessage="Tecnologia é um item obrigatório")]
        public int TecnologiaID { get; set; }
        [Required(ErrorMessage="Lista de Starters é um item obrigatório")]
        public List<int> StartersID { get; set; }
    }
}