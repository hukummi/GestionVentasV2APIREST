﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GL.GestionVentas.Domain.Models
{
    public class ProductDTO
    {
        public string Codigo { get; set; }
        public string Marca { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
    }
}