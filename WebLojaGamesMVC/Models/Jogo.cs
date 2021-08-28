using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.Linq;
using System.Web;

namespace WebLojaGamesMVC.Models
{
    public class Jogo
    {
        [Required(ErrorMessage = "O código é obrigatório")]
        public ushort JogoCod { get; set; }

        [StringLength(100, MinimumLength = 3, ErrorMessage = "Insira no mínimo 3 caracteres")]
        public string JogoNome { get; set; }

        [StringLength(100, MinimumLength = 3, ErrorMessage = "Insira no mínimo 3 caracteres")]
        public string JogoDev { get; set; }

        [Required(ErrorMessage = "Genero não encontrado")]
        public string JogoGen { get; set; }

        [Required(ErrorMessage = "Faixa etária inválida")]
        public string JogoFaixa { get; set; }

        [Required(ErrorMessage = "Plataforma desconhecida")]
        public string JogoPlat { get; set; }

        [Required(ErrorMessage = "Data inválida")]
        public string JogoAno { get; set; }

        [StringLength(300, MinimumLength = 10, ErrorMessage = "Sinopse muito curta!")]
        public string JogoSin { get; set; }
    }
}