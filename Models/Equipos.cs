namespace API_LOGISTICA_EF_NET.Models; public class Equipos
{
    public int Id { get; set; }
    public int? IdCamion { get; set; }
    public int? IdAcoplado { get; set; }
    public int? IdChofer { get; set; }
    public bool? Activo { get; set; }
}