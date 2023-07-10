namespace API_LOGISTICA_EF_NET.Models;
public class Provincia
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string NombreCorto { get; set; }
    public float? Latitud { get; set; }
    public float? Longitud { get; set; }
}