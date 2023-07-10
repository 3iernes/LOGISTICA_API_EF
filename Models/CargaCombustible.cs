namespace API_LOGISTICA_EF_NET.Models
{
    public class CargaCombustible
    {
        public int Id { get; set; }
        public int? IdCamion { get; set; }
        public int? IdConductor { get; set; }
        public decimal? Kms { get; set; }
        public decimal? Litros { get; set; }
        public decimal? PrecioLitro { get; set; }
        public decimal? PrecioFinal { get; set; }
        public decimal? Ticket { get; set; }
        public decimal? Vale { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public DateTime? FechaCarga { get; set; }
        public string Origen { get; set; }
    }

}
