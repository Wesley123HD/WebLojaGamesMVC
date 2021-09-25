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

        [Required(ErrorMessage = "O código é obrigatório")]
        public ushort CliCod { get; set; }
        [Required(ErrorMessage = "Insira no mínimo 3 caracteres")]
        public string CliNome { get; set; }

        [Required(ErrorMessage = "CPF inválido")]
        public string CliCPF { get; set; }

        [Required(ErrorMessage = "Data inválida")]
        public DateTime CliNasc { get; set; }

        [Required(ErrorMessage = "Endereço inválida")]
        public string CliCEP { get; set; }

        [Required(ErrorMessage = "Número de celular inválido")]
        public string CliCel { get; set; }

        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*",
            ErrorMessage = "Email inválido")]
        public string CliEmail { get; set; }
    }
}