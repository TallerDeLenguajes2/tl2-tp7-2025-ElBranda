namespace tl2_tp7_2025_ElBranda_main.Models;

public class PresupuestosDetalle {
    public Productos producto {private set; get;}
    public int cantidad {private set; get;}

    public PresupuestosDetalle(Productos p, int c) {
        producto = p;
        cantidad = c;
    }
}