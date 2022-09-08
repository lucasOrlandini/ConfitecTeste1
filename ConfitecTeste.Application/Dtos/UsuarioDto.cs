﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfitecTeste.Application.Dtos
{
   public class UsuarioDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime Data { get; set; }
        public int EscolaridadeId { get; set; }
        public int HistoricoEscolarId { get; set; }

    }
}
