using System;

namespace FinanzasMamaApp.Models;

public class Movimiento
{
    public int Id { get; set; }
    public DateTime Fecha { get; set; }
    public string Tipo { get; set; } = "";
    public decimal Monto { get; set; }
    public string Detalle { get; set; } = "";
    public string? Comentario { get; set; }
}