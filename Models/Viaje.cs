namespace API_LOGISTICA_EF_NET.Models;public class Viaje { public int Id { get; set; }
    public int? ProvinciaId { get; set; }
    public int? LocalidadId { get; set; }
    public int? TipoTarifaId { get; set; }
    public float? Tarifa { get; set; }
    public string Nombre { get; set; }
    public string Obs { get; set; }
    public bool? Activo { get; set; }
    public int? UbicacionOrigenId { get; set; }
    public int? UbicacionDestinoId { get; set; }
    public int? ProductoId { get; set; }
    public float? Kilos { get; set; }
    public int? KmCamionInicio { get; set; }
    public int? KmCamionFinal { get; set; }
    public int? EstadoId { get; set; }
    public DateTime? FechaCreacion { get; set; }
    public DateTime? FechaFin { get; set; }
    public DateTime? FechaInicio { get; set; }
    public int? TipoViajeId { get; set; }
    public int? ProformaId { get; set; }
    public int? ClienteId { get; set; }
    public int? OperativoId { get; set; }
    public float? TarifaChofer { get; set; }
    public int? TTarifaClienteId { get; set; }
    public int? TTarifaProveedorId { get; set; } }