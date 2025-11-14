namespace tl2_tp7_2025_ElBranda_main.Models;

public class Presupuestos {
    int idPresupuesto;
    string nombreDestinatario;
    DateTime fechaCreacion;
    List<PresupuestosDetalle> detalle;

    public Presupuestos(int id, string nombreDestinatario, DateTime fecCreacion, List<PresupuestosDetalle> detalle) {
        idPresupuesto = id;
        this.nombreDestinatario = nombreDestinatario;
        fechaCreacion = fecCreacion;
        this.detalle = detalle;
    }

    public float MontoPresupuesto() {
        if (detalle == null) return 0;

        return detalle.Select(pd => pd.producto.precio * pd.cantidad).Sum();
    }

    public float MontoPresupuestoConIVA() {
        return MontoPresupuesto() * 1.21f;
    }

    public int CantidadProductos() {
        if (detalle == null) return 0;

        return detalle.Select(pd => pd.cantidad).Sum();
    }
}