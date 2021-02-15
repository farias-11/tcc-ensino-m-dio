using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TCC2019.Models
{
    public class Register
    {
        [Required(ErrorMessage = "Digite seu nome de usuario", AllowEmptyStrings = false)]
        public string Usuario { get; set; }
        [Required(ErrorMessage = "Digite sua senha", AllowEmptyStrings = false)]
        [StringLength(100, ErrorMessage = "Senha deve ter no mínimo 8 caractéres", MinimumLength = 4)]
        public string Senha { get; set; }
        [Required(ErrorMessage = "Confirme sua senha", AllowEmptyStrings = false)]
        [Compare("Senha", ErrorMessage = "senha diferente")]
        public string ConfirmarSenha { get; set; }
        [Required(ErrorMessage = "Digite seu nome", AllowEmptyStrings = false)]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Digite seu sobrenome", AllowEmptyStrings = false)]
        public string Sobrenome { get; set; }
        [Required(ErrorMessage = "Digite seu e-mail", AllowEmptyStrings = false)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Digite seu número", AllowEmptyStrings = false)]
        [StringLength(20, ErrorMessage = "(**)*********", MinimumLength = 11)]
        public string NumCel { get; set; }
    }
}