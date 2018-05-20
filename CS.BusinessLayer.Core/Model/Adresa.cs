using CS.BusinessLayer.Dictionaries;
namespace CS.BusinessLayer.Model
{
    public class Adresa
    {
        string Judet { get; set; }
        TipLocalitate? TipLocalitate { get; set; }
        string Localitate { get; set; }
        string Strada { get; set; }
    }
}
