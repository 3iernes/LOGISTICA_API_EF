namespace API_LOGISTICA_EF_NET.Models;
public class VehiculoCubierta
{
    public int Id { get; set; }
    public int? VehiculoId { get; set; }
    public int? CubiertaId { get; set; }
    public DateTime? FechaAccion { get; set; }
    public string Accion { get; set; }
    public bool? Activo { get; set; }
    public int? KilometrosTractor { get; set; }
}