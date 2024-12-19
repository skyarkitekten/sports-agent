using System.ComponentModel.DataAnnotations;

public class ApiSettings
{
    [Required]
    public string ModelId { get; set; } = null!;

    [Required]
    [Url]
    public string Endpoint { get; set; } = null!;

    [Required]
    public string ApiKey { get; set; } = null!;
}
