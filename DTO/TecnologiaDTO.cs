using System.ComponentModel.DataAnnotations;

namespace ControleStarter.DTO
{
    public class TecnologiaDTO
    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage="Nome da tecnologia é um item obrigatório")]
        [StringLength(100, ErrorMessage = "Nome da tecnologia excede ao tamanho, tente um nome com menos caracteres.")]
        [MinLength(2, ErrorMessage = "Nome da tecnologia menor que tamanho requerido, tente um nome com mais caracteres.")]
        public string Nome { get; set; }
        [Required(ErrorMessage="Descrição é um item obrigatório")]
        [StringLength(500, ErrorMessage = "Descrição excede ao tamanho, tente um nome com menos caracteres.")]
        [MinLength(2, ErrorMessage = "Descrição menor que tamanho requerido, tente um nome com mais caracteres.")]
        public string Descricao { get; set; }
    }
}