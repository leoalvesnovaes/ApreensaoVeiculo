using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ApreensaoVeiculo.Dominio
{
    public class Veiculo
    {

        public int Codigo { get; set; }

        [DisplayName("Placa")]
        public string Placa { get; set; }

        [DisplayName("Renavan")]
        public string Renavan { get; set; }

        [DisplayName("Marca")]
        public string Marca { get; set; }

        [DisplayName("Modelo")]
        public string Modelo { get; set; }

        [DisplayName("Versao")]
        public string Versao { get; set; }

        [DisplayName("Ano")]
        public string Ano { get; set; }

        [DisplayName("Tipo")]
        public string Tipo { get; set; }

        [DisplayName("Km")]
        public string Km { get; set; }

        [DisplayName("Portas")]
        public string Portas { get; set; }

        [DisplayName("Cor")]
        public string Cor { get; set; }



    }
}
