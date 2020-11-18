using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace ApreensaoVeiculo.Dominio
{
    public class Usuarios
    {

        public int Codigo { get; set; }

        [DisplayName("Nome")]
        [Required(ErrorMessage = "Preencha o Descricao do usuário!")]
        public string Descricao { get; set; }

        [DisplayName("Cargo")]
        [Required(ErrorMessage = "Preencha o cargo do usuário!")]
        public string Cargo { get; set; }

        [DisplayName("Data de Cadastro")]
        [Required(ErrorMessage = "Preencha a data de cadastro!")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Data { get; set; }

        [DisplayName("Login")]
        [Required(ErrorMessage = "Preencha o login do usuário!")]
        public string Login { get; set; }

        [DisplayName("Senha")]
        [Required(ErrorMessage = "Preencha o senha do usuário!")]
        public string Senha { get; set; }
    }
}
