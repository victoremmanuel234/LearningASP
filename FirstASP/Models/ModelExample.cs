using System;
using System.ComponentModel.DataAnnotations;
using FirstASP.CustomValidations;
using Microsoft.AspNetCore.Components;

namespace FirstASP.Models;

public class ModelExample
{
    [Required (ErrorMessage = "BookId is required")] 
    [Display(Name = "Book Id")]
    public int? BookId { get; set; }

    [Display(Name = "Book Name")]
    [Required(ErrorMessage = "{0} cannot be empty")] 
    public string? BookName { get; set; }
    [ValidateMarriage(ErrorMessage = " have to bein marriage ")]
    [Display(Name = "Book Author")]
    public string? BookAuthor { get; set; }

    public override string ToString()
    {
        return $"BookId: {BookId}, BookName: {BookName}, BookAuthor: {BookAuthor}";
    }

}
