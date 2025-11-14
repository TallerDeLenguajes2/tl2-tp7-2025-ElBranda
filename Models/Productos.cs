namespace tl2_tp7_2025_ElBranda_main.Models;

public class Productos {
    public int idProducto {set; get;}
    public string? descripcion {get; set;}
    public int precio {set; get;}

    public Productos(int id, string? desc, int precio) {
        idProducto = id;
        descripcion = desc;
        this.precio = precio;
    }
}