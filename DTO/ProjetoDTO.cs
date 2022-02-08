using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ControleStarter.Models;

namespace ControleStarter.DTO
{
    public class ProjetoDTO
    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage="Avaliação é um item obrigatório")]
        [StringLength(50, ErrorMessage = "Avaliação excede ao tamanho, tente um nome com menos caracteres.")]
        [MinLength(2, ErrorMessage = "Avaliação menor que tamanho requerido, tente um nome com mais caracteres.")]
        public string Avaliacao { get; set; }
        [Required]
        public int ModuloID { get; set ;}
        [Required]
        public int StarterID { get; set; }
        
    }
}