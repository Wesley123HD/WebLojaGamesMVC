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

        [StringLength(20, MinimumLength = 2, ErrorMessage = "Gênero não encontrado")]
        public string JogoGen { get; set; }

        [StringLength(2, MinimumLength = 1, ErrorMessage = "Exemplo: 'L, 10, 12, 14, 16, 18'")]
        public string JogoFaixa { get; set; }

        [StringLength(20, MinimumLength = 2, ErrorMessage = "Plataforma desconhecida")]
        public string JogoPlat { get; set; }

        [Required(ErrorMessage = "Data inválida")]
        public DateTime JogoAno { get; set; }

        [StringLength(300, MinimumLength = 10, ErrorMessage = "Sinopse muito curta!")]
        public string JogoSin { get; set; }
    }
}