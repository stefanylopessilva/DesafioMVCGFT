using System.ComponentModel.DataAnnotations;

namespace ControleStarter.DTO
{
    public class StarterDTO
    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage="Nome do(a) Stater é um item obrigatório")]
        [StringLength(100, ErrorMessage = "Nome do(a) Stater excede ao tamanho, tente um nome com menos caracteres.")]
        [MinLength(2, ErrorMessage = "Nome do(a) Stater menor que tamanho requerido, tente um nome com mais caracteres.")]
        public string Nome { get; set; }
        [Required(ErrorMessage="4 letras é um item obrigatório")]
        [StringLength(4, ErrorMessage = "4 letras excede ao tamanho, insira apenas 4 caracteres.")]
        [MinLength(4, ErrorMessage = "4 letras menor que tamanho requerido, insira apenas 4 caracteres.")]
        public string QuatroLetras { get; set; }
        [Required(ErrorMessage="Tecnologia é um item obrigatório")]
        public int TecnologiaID { get; set; }
        public int GrupoID { get; set; }
        [Required(ErrorMessage="Programa Start é um item obrigatório")]
        public int ProgramaStartID { get; set; }
        [Required(ErrorMessage="Módulo é um item obrigatório")]
        public int ModuloID { get; set; }
    }
}