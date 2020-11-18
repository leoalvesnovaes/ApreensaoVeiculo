using System;
using System.Collections.Generic;
using System.ComponentModel;


namespace ApreensaoVeiculo.Dominio.ViewModel
{
    public class ApreensaoCombo
    {

        public IEnumerable<Marca> ListaMarca { get; set; }

        public Apreensao apreensao { get; set; }
    }
}
