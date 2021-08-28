using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.Linq;
using System.Web;

namespace WebLojaGamesMVC.Models
{
    public class Cliente
    {
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Insira no mínimo 3 caracteres")]
        public string CliNome { get; set; }

        [MinLength(12, ErrorMessage = "CPF inválido")]
        public string CliCPF { get; set; }

        [Required(ErrorMessage = "Data inválida")]
        public string CliNasc { get; set; }

        [Required(ErrorMessage = "Endereço inválida")]
        public string CliEnd { get; set; }

        [MinLength(9, ErrorMessage = "Número de celular inválido")]
        public string CliCel { get; set; }

        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*",
            ErrorMessage = "Email inválido")]
        public string CliEmail { get; set; }
    }
}