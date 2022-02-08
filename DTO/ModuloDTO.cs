using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ControleStarter.Models;

namespace ControleStarter.DTO
{
    public class ModuloDTO
    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage="Nome do Módulo é um item obrigatório")]
        [StringLength(50, ErrorMessage = "Nome do Módulo excede ao tamanho, tente um nome com menos caracteres.")]
        [MinLength(3, ErrorMessage = "Nome do Módulo menor que tamanho requerido, tente um nome com mais caracteres.")]
        public string Nome { get; set; }
        [Required(ErrorMessage="Descrição do projeto é um item obrigatório")]
        [StringLength(500, ErrorMessage = "Descrição do projeto excede ao tamanho, tente um nome com menos caracteres.")]
        [MinLength(3, ErrorMessage = "Descrição do projeto menor que tamanho requerido, tente um nome com mais caracteres.")]
        public string Projeto { get; set; }
    }
}