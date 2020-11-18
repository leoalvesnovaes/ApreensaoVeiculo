using System;
using System.Collections.Generic;

namespace ApreensaoVeiculo.Dominio
{
    public class Consulta
    {
        public IEnumerable<Apreensao> ListaApreensao { get; set; }

        public TabelaPreco TabelaPreco { get; set; }         
    }
}
