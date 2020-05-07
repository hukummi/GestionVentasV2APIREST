﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GL.GestionVentas.Domain.Entities
{
    public class Ventas
    {
        public int VentasId { get; set; }
        public DateTime Fecha { get; set; }
        public int CarritoId { get; set; }

        public virtual Carrito Carrito { get; set; }
    }
}
