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

        [StringLength(12, MinimumLength = 12, ErrorMessage = "CPF inválido")]
        public string FuncCPF { get; set; }

        [StringLength(11, MinimumLength = 11, ErrorMessage = "RG inválido")]
        public string FuncRG { get; set; }

        [Required(ErrorMessage = "Data inválida")]
        public DateTime FuncNasc { get; set; }

        [StringLength(8, MinimumLength = 8, ErrorMessage = "Endereço inválida")]
        public string FuncCEP { get; set; }

        [StringLength(9, MinimumLength = 9, ErrorMessage = "Número de celular inválido")]
        public string FuncCel { get; set; }

        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", 
            ErrorMessage = "Email inválido")]
        public string FuncEmail { get; set; }

        [Required(ErrorMessage = "O cargo é obrigatório")]
        public string FuncCargo { get; set; }
    }
}