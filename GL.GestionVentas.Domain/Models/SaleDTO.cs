﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GL.GestionVentas.Domain.Models
{
    public class SaleDTO
    {
        public string Dni { get; set; }
        public List<CartDTO> Carts { get; set; }
    }
}
