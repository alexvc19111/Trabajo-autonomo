public class program
{
    static void Main(string[]args)
    {
        ProductoSimple p1= new ProductoSimple("Memoria RAM 4GB",50,"Intel");
        ProductoSimple p2= new ProductoSimple("Cascos Gamer",20,"Asus");
        ProductoSimple p3=new ProductoSimple("Zapatos para cesped",200,"Adidas");
        ProductoSimple p4=new ProductoSimple("Balon de futbol",100,"Adidas");
        ProductoSimple p5=new ProductoSimple("Camisa",50,"Gucci");
        compuesto c1=new compuesto("Productos para pc");
        c1.AddProducto(p1);
        c1.AddProducto(p2);
        compuesto c2=new compuesto("Productos para futbol");
        c2.AddProducto(p3);
        c2.AddProducto(p4);
        Ordenventa orden1=new Ordenventa(1,"Marcelo", new DateOnly(2022,12,29));
        orden1.AddProducto(c1);
        orden1.AddProducto(c2);
        orden1.AddProducto(p5);
        orden1.Imprimirorden();

    }
}


