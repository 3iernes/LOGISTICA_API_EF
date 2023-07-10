namespace API_LOGISTICA_EF_NET.Models;
public class Localidades
{
    public int Id { get; set; }
    public int? IdProvincia { get; set; }
    public string Nombre { get; set; }
    public double? Latitud { get; set; }
    public double? Longitud { get; set; }
}