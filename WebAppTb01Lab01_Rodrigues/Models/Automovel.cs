using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppTb01Lab01_Alexandre.Models
{
    public class Automovel
    {
        public int AutomovelId { get; set; }

        [Required(ErrorMessage = "Tipo é obrigatorio")]
        public Tipo Tipo { get; set; }

        [Required(ErrorMessage = "Descrição é obrigatorio")]
        [StringLength(300, ErrorMessage = "Maxímo de 300 caracteres")]
        public String Descriçao { get; set; }

        [Required(ErrorMessage = " Marca é obrigatorio")]
        [StringLength(100, ErrorMessage = " Maxímo de 100 caracteres")]
        public String Marca { get; set; }

        [Required(ErrorMessage = "Disponivel é obrigatorio")]
        public bool Disponivel { get; set; }

        [Required(ErrorMessage = "Data de cadastro é obrigatorio")]
        public DateTime DataCadastro { get; set; }
    }
}
