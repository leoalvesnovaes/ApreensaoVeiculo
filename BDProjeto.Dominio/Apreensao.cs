using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using ApreensaoVeiculo.Dominio.ViewModel;


namespace ApreensaoVeiculo.Dominio
{
    public class Apreensao
    {

        public int Codigo { get; set; }

        [DisplayName("Data Apreensão")]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Required(ErrorMessage = "Preencha a data!")]
        public string DataApreensao { get; set; }

        [DisplayName("Data Liberação")]
        public string DataLiberacao { get; set; }

        [DisplayName("Guia Recolhimento")]
        public string GuiaRecolhimento { get; set; }

        [DisplayName("Local Recolhimento")]
        //[Required(ErrorMessage = "Preencha a guia!")]
        public string LocalRecolhimento { get; set; }
        
        [DisplayName("Motivo")]
        public string Motivo { get; set; }




        //CONDUTOR

        [DisplayName("Nome Condutor")]
        [Required(ErrorMessage = "Preencha o Nome do usuário!")]
        public string Nome { get; set; }

        [DisplayName("CNH")]
        //[Required(ErrorMessage = "Preencha o Documento do usuário!")]
        public string Cnh { get; set; }

        [DisplayName("CPF")]
        //[Required(ErrorMessage = "Preencha o Descricao do usuário!")]
        public string Cpf { get; set; }

        [DisplayName("RG")]
        //[Required(ErrorMessage = "Preencha o Descricao do usuário!")]
        public string Rg { get; set; }



        //VEICULO

        [DisplayName("Placa")]
        [Required(ErrorMessage = "Preencha a Placa do veículo!")]
        public string Placa { get; set; }

        [DisplayName("Renavan")]
        //[Required(ErrorMessage = "Preencha o Renavan do veículo!")]
        public string Renavan { get; set; }

        [DisplayName("Marca")]
        [Required(ErrorMessage = "Preencha a Marca do veículo!")]
        public string Marca { get; set; }

        [DisplayName("Modelo")]
        [Required(ErrorMessage = "Preencha o Modelo do veículo!")]
        public string Modelo { get; set; }

        [DisplayName("Versao")]
        [Required(ErrorMessage = "Preencha a Versão do veículo!")]
        public string Versao { get; set; }

        [DisplayName("Tipo")]
        [Required(ErrorMessage = "Preencha o Tipo do veículo!")]
        public string Tipo { get; set; }
        
        [DisplayName("Km")]
        public string Km { get; set; }

        [DisplayName("Portas")]
        [Required(ErrorMessage = "Preencha a quantidade de Portas do veículo!")]
        public string Portas { get; set; }

        [DisplayName("Cor")]
        [Required(ErrorMessage = "Preencha a Cor do veículo!")]
        public string Cor { get; set; }

        [DisplayName("Ano")]
        [Required(ErrorMessage = "Preencha o Ano do veículo!")]
        public string Ano { get; set; }




        [DisplayName("Valor Total")]
        [Required(ErrorMessage = "Valor total apreendido")]
        public decimal ValorTotal { get; set; }

        [DisplayName("Total Dias")]
        [Required(ErrorMessage = "Qtde dias apreendido")]
        public int QtdeDias { get; set; }


        public ApreensaoCombo listaMarca { get; set; }

        
    }
}
