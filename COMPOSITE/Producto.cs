using System;
using System.Collections.Generic;
//Clase padre producto, la cual se la interpreta como el elemento Component el cual posee el patron de desarrollo 
//COMPOSITE y posee las operaciones y atributos minimos a usar
public abstract class Producto
    {
        public String nombre{get;set;}
        public double precio;
        public Producto(String nombre, double precio)
        {
            this.nombre=nombre;
            this.precio=precio;
        }
        public virtual double getprecio()
        {
            return precio;
        }
        public virtual void setprecio(double precio)
        {
            this.precio=precio;
        }
    }