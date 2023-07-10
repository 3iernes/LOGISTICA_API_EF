namespace API_LOGISTICA_EF_NET.Models;public class VPCargaCombustible { public int Id { get; set; }
    public int? CamionId { get; set; }
    public int? ConductorId { get; set; }
    public decimal? Kms { get; set; }
    public decimal? Litros { get; set; }
    public decimal? PrecioLitro { get; set; }
    public decimal? PrecioFinal { get; set; }
    public decimal? Ticket { get; set; }
    public decimal? Vale { get; set; }
    public DateTime? FechaRegistro { get; set; }
    public DateTime? FechaCarga { get; set; }
    public string Origen { get; set; } }