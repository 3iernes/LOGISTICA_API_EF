namespace API_LOGISTICA_EF_NET.Models;
public class RoutesFront
{
    public int Id { get; set; }
    public string Path { get; set; }
    public string Element { get; set; }
    public string Descrip { get; set; }
    public bool? Display { get; set; }
    public string Category { get; set; }
}