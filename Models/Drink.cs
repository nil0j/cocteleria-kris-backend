namespace cocteleria_kris_backend.Models;

public class Drink
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Price { get; set; }
    public bool Alcoholic { get; set; }
    public string? Flavour { get; set; }
    public string? PrimaryType { get; set; }
    public string? SecondaryType { get; set; }
    public string? Recipe { get; set; }
    public Int16 Adelhyde { get; set; }
    public Int16 PowderedDelta { get; set; }
    public Int16 BronsonExtract { get; set; }
    public Int16 Flanergide { get; set; }
    public Int16 Karmotrine { get; set; }
    public bool Ice { get; set; }
    public bool Aged { get; set; }
    public string? Preparation { get; set; }
    public string? Shortcut { get; set; }
    public string? Description { get; set; }
    public bool KarmotrineOptional { get; set; }
    public string? Filename { get; set; }

    public string? FilenameFull
    {
        get
        {
            if (this.Filename == null)
            {
                return null;
            }

            return "/static/drinks/" + this.Filename;
        }
    }
}
