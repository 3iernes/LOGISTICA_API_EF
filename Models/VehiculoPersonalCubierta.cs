namespace API_LOGISTICA_EF_NET.Models;
public class VehiculoPersonalCubierta
{
    public int Id { get; set; }
    public int? VehiculoId { get; set; }
    public int? CubiertaId { get; set; }
    public DateTime? FechaAccion { get; set; }
    public bool? Accion { get; set; }
    public bool? Activo { get; set; }
    public int? Kilometros { get; set; }
}