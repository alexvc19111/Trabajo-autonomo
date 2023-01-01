using System;
using System.Collections.Generic;
//Clase hija de producto la cual se interpreta como el elemento Leaf que posee el patron de desarrollo 
//COMPOSITE y posee los productos simples que luego se agregaran al elemento Composite
public class ProductoSimple:Producto
{
    private string marca{get;set;}
    public ProductoSimple(string nombre, double precio, string marca):base(nombre,precio)
    {
        this.marca=marca;
    }
}