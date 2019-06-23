﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CI.Domain.Entity
{
    public class Investimento
    {
        public Investimento()
        {
                
        }

        public int InvestimentoId { get; set; }
        public string Tipo { get; set; }
        public decimal Valor { get; set; }

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}
