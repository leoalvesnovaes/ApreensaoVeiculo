using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace ApreensaoVeiculo.Dominio
{
    public class TabelaPreco
    {
        public int Codigo { get; set; }
        
        [DisplayName("Descrição")]
        [Required(ErrorMessage = "Preencha a descrição!")]
        public string Descricao { get; set; }

        [DisplayName("Valor Diária")]
        [Required(ErrorMessage = "Preencha o valor da diária!")]
        public string ValorDiaria { get; set; }

        [DisplayName("Valor Guincho")]
        [Required(ErrorMessage = "Preencha o valor do guincho!")]
        public string ValorGuincho { get; set; }

        [DisplayName("Data Cadastro")]
        [Required(ErrorMessage = "Preencha a data!")]
        public DateTime DataCadastro { get; set; }
        
        [DisplayName("Data Alteração")]
        [Required(ErrorMessage = "Preencha a data de alteração!")]
        public DateTime DataAlteracaoCadastro { get; set; }

    }
}
