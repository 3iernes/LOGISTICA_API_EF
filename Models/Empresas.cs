namespace API_LOGISTICA_EF_NET.Models; public class Empresas
{
    public int Id { get; set; }
    public string NombEmpresa { get; set; }
    public bool? Activo { get; set; }
    public long? Cuit { get; set; }
}