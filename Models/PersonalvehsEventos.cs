namespace API_LOGISTICA_EF_NET.Models;
public class PersonalvehsEventos
{
    public int Id { get; set; }
    public int? IdCategoria { get; set; }
    public int? IdVehiculo { get; set; }
    public string DescEvento { get; set; }
    public string Obs { get; set; }
    public DateTime? Fecha { get; set; }
    public int? Kilometros { get; set; }
}