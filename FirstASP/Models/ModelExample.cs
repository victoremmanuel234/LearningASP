using System;

namespace FirstASP.Models;

public class ModelExample
{
    public int? BookId { get; set; }
    public string? BookName { get; set; }
    public string? BookAuthor { get; set; }

    public override string ToString()
    {
        return $"BookId: {BookId}, BookName: {BookName}, BookAuthor: {BookAuthor}";
    }

}
