using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.Linq;
using System.Web;

namespace WebLojaGamesMVC.Models
{
    public class Funcionario
    {
        [Required(ErrorMessage = "O código é obrigatório")]
        public ushort FuncCod { get; set; }

        [StringLength(50, MinimumLength = 3, ErrorMessage = "Insira no mínimo 3 caracteres")]
        public string FuncNome { get; set; }

        [MinLength(12, ErrorMessage = "CPF inválido")]
        public string FuncCPF { get; set; }

        [MinLength(11, ErrorMessage = "RG inválido")]
        public string FuncRG { get; set; }

        [Required(ErrorMessage = "Data inválida")]
        public string FuncNasc { get; set; }

        [Required(ErrorMessage = "Endereço inválida")]
        public string FuncEnd { get; set; }

        [MinLength(9, ErrorMessage = "Número de celular inválido")]
        public string FuncCel { get; set; }

        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", 
            ErrorMessage = "Email inválido")]
        public string FuncEmail { get; set; }

        [Required(ErrorMessage = "O cargo é obrigatório")]
        public string FuncCargo { get; set; }
    }
}