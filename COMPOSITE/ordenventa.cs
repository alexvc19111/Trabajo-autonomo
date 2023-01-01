public class Ordenventa
{
    public long ID{get;set;}
    public string cliente{get;set;}
    public DateOnly fechayhora{get;set;}
    private List<Producto>productos=new List<Producto>();
    public Ordenventa(long ID,string cliente,DateOnly fechayhora)
    {
        this.ID=ID;
        this.cliente=cliente;
        this.fechayhora=fechayhora;
    }
    public List<Producto> getProductos()
    {
        return productos;
    }
    public void setProductos(List<Producto> productos)
    {
        this.productos=productos;
        }
 public double getprecio()
    {
        double precio=0d;
        foreach(Producto x in productos)
        {
            precio +=x.getprecio();
        }
        return precio;
    } 
    public void AddProducto(Producto product)
    {
        productos.Add(product);
    }
    public void RemoverProducto(Producto product)
    {
        productos.Remove(product);
    }
    public void Imprimirorden()
    {
        Console.WriteLine("=============================================");
        Console.WriteLine("Orden: "+ID);
        Console.WriteLine("Fecha de orden: "+fechayhora);
        Console.WriteLine("Cliente: "+cliente);
        Console.WriteLine("Productos:");
        foreach(Producto x in productos)
        {
            Console.WriteLine(x.nombre+" $"+x.getprecio());
        }
        Console.WriteLine("Precio total: $"+getprecio());
        Console.WriteLine("=============================================");
    }
}