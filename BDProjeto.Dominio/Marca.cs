using System;
using System.Collections.Generic;
using System.ComponentModel;


namespace ApreensaoVeiculo.Dominio
{
    public class Marca
    {

        public int Codigo { get; set; }

        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        

    }
}
