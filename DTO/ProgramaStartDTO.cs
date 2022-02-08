using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ControleStarter.Models;

namespace ControleStarter.DTO
{
    public class ProgramaStartDTO
    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage="Nome da turma é um item obrigatório")]
        [StringLength(50, ErrorMessage = "Nome da turma excede ao tamanho, tente um nome com menos caracteres.")]
        [MinLength(2, ErrorMessage = "Nome da turma menor que tamanho requerido, tente um nome com mais caracteres.")]
        public string Nome { get; set; }
        [Required(ErrorMessage="Data Inicial é um item obrigatório")]
        [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
        public DateTime DataInicial { get; set; }
        [Required(ErrorMessage="Data Final é um item obrigatório")]
        [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
        public DateTime DataFinal { get; set; }
    }
}