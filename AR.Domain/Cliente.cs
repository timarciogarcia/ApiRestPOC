using System;
using System.ComponentModel.DataAnnotations;

namespace AR.Domain
{
    public class Cliente
    {
        [Key]   
        public Guid Id { get; set; }
        
        [Required(ErrorMessage ="P campo {0} é requerido !")]
        [MaxLength(50, ErrorMessage ="O campo {0}, deve ter no máximo {1} caracteres. ")]
        public string Nome { get; set; }

        public string CPF { get; set; }

        public int Idade { get; set; }

    }
}
