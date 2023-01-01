using System;
using System.Collections.Generic;
//Clase hija de producto, la cual se interpreta como el elemento Composite que posee el patron de dessarrollo COMPOSITE, 
//y posee los productos simples agreagados en mi clase program
public class compuesto:Producto
{
    private List<Producto>productos=new List<Producto>();
    //Lista en la que se almacenaran los productos simples que se apregen a la clase producto compuesto
    public compuesto(string nombre):base(nombre,0)
    {}
    public override double getprecio()
    {
        double precio=0d;
        foreach(Producto x in productos)
        {
            precio +=x.getprecio();
        }
        return precio;
        //Suma del precio total de la clase producto compuesto
    }
    public override void setprecio(double precio)
    {
        throw new NotSupportedException();
    }
    public void AddProducto(Producto product)
    {
        this.productos.Add(product);
    }
    //Clase para agregar un producto nuevo a la clase producto compuesto
    public Boolean RemoverProducto(Producto product)
    {
        return this.productos.Remove(product);
    }
    //Clase para remover un producto nuevo a la clase producto compuesto
}