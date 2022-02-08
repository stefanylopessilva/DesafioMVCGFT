using System;
using System.ComponentModel.DataAnnotations;

namespace ControleStarter.DTO
{
    public class DailyDTO
    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage="Data é um item obrigatório")]
        [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
        public DateTime Data { get; set; }
        [Required(ErrorMessage="Fazendo é um item obrigatório")]
        [MinLength(2, ErrorMessage = "Descrição de fazendo menor que tamanho requerido, tente um nome com mais caracteres.")]
        public string Fazendo { get; set; }
        [Required(ErrorMessage="Feito é um item obrigatório")]
        [MinLength(2, ErrorMessage = "Descrição de feito menor que tamanho requerido, tente um nome com mais caracteres.")]
        public string Feito { get; set; }
        public string Impedimentos { get; set; }
        [Required(ErrorMessage="Presença é um item obrigatório")]
        [Range(0,2,ErrorMessage ="Presença inválida")]
        public int Presenca { get; set; }
        [Required]
        public int GrupoID { get; set; }
        [Required]
        public int ModuloID { get; set; }
        public int StarterID { get; set; }
    }
}