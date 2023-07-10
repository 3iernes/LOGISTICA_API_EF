namespace API_LOGISTICA_EF_NET.Models;public class ViajeEquipo { public int Id { get; set; }
    public int? ViajeId { get; set; }
    public int? ChoferId { get; set; }
    public int? CamionId { get; set; }
    public int? AcopladoId { get; set; }
    public decimal? KmInicio { get; set; }
    public decimal? KmFin { get; set; }
    public int? EquipoId { get; set; }
    public float? Toneladas { get; set; }
    public TimeSpan? TiempoTrabajado { get; set; }
    public bool? Activo { get; set; }
    public bool? SonKmIdaVuelta { get; set; }
    public int? CantControlesDescarga { get; set; }
    public DateTime? FechaInicio { get; set; }
    public DateTime? FechaFin { get; set; } }