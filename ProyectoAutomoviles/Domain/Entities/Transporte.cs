namespace ProyectoAutomoviles.Domain.Entities;

public class Transporte
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Author { get; set; }
    public DateTime PublicationDate { get; set; }
}
