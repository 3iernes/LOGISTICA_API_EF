namespace API_LOGISTICA_EF_NET.Models;
public class VehiculoPersonal
{
    public int Id { get; set; }
    public string Patente { get; set; }
    public string DescVehiculo { get; set; }
    public bool? Activo { get; set; }
    public DateTime? FechaSeguro { get; set; }
    public DateTime? FechaVTV { get; set; }
    public int? Kilometros { get; set; }
}