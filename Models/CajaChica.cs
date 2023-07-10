namespace API_LOGISTICA_EF_NET.Models
{
    public class CajaChica
    {
        public int Id { get; set; }
        public int? IdChofer { get; set; }
        public int? IdMovimiento { get; set; }
        public float? Ingreso { get; set; }
        public float? Egreso { get; set; }
        public DateTime? Fecha { get; set; }
        public string Obs { get; set; }
        public int? NroPuntoVenta { get; set; }
        public int? NroComprobante { get; set; }
        public string Proveedor { get; set; }
    }
}
