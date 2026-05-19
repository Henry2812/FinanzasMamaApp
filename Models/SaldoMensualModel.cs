using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

[Table("saldos_mensuales")]
public class SaldoMensualModel : BaseModel
{
    [PrimaryKey("id")]
    public int id { get; set; }

    public string user_id { get; set; } = "";
    public string mes { get; set; } = "";
    public decimal saldo_anterior { get; set; }
}