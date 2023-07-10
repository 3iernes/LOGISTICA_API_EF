namespace API_LOGISTICA_EF_NET.Models;
public class Operativos
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public int? IdTipo { get; set; }
    public bool? Activo { get; set; }
    public int? IdEstado { get; set; }
    public long? IdProforma { get; set; }
}