﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LestePericiasMobile.Models
{
    class FotoDTO
    {
        public long IdFoto { get; set; }
        public long IdVistoria { get; set; }
        public string Descricao { get; set; }
        public byte[] Source { get; set; }
        public string Categoria { get; set; }
    }
}
