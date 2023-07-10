namespace API_LOGISTICA_EF_NET.Models
{
    public class CostoKmHoras
    {
        public int Id { get; set; }
        public DateTime? Fecha { get; set; }
        public decimal? KmCamionero { get; set; }
        public decimal? HoraTys { get; set; }
    }
}
