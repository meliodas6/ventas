﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ventas.Modelos
{
   public class  Producto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categotia { get; set; }

        public Producto(int id, string descripcion, double precio, Categoria categoria )
        {
            Id = id;
            Descripcion = descripcion;
            Precio = precio;
            Categotia = categoria;
            CategoriaId = categoria.Id;
        }
    }
}
