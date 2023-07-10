namespace API_LOGISTICA_EF_NET.Models;public class ViajeCubierta { public int Id { get; set; }
    public int ViajeId { get; set; }
    public int CubiertaId { get; set; }
    public int? KmCamion { get; set; }
    public bool? Inicio { get; set; }
    public bool? Activo { get; set; } }