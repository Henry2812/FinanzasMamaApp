using System;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace FinanzasMamaApp.Models;

[Table("movimientos")]
public class MovimientoModel : BaseModel
{
    [PrimaryKey("id")]
    public int id { get; set; }

    public string user_id { get; set; } = "";
    public string fecha { get; set; } = "";
    public string tipo { get; set; } = "";
    public decimal monto { get; set; }
    public string detalle { get; set; } = "";
    public string comentario { get; set; } = "";
}