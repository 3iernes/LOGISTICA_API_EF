namespace API_LOGISTICA_EF_NET.Models; public class CubiertasVehPersonal
{
    public int Id { get; set; }
    public string Numero { get; set; }
    public bool? Activo { get; set; }
    public int? IdMarca { get; set; }
    public int? IdMedida { get; set; }
}