using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blank.Models
{
    public class GuestResponse
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Proszę podać imię i nazwisko.")]
        [MaxLength(30, ErrorMessage ="Pole nie może byc dłuższe niż 30 znaków.")]
        public string Name{ get; set; }
        [Required(ErrorMessage = "Proszę podać adres e-mail.")]
        [EmailAddress(ErrorMessage = "Adres e-mail jest niepoprawny.")]
        public string Email{ get; set; }
        [Required(ErrorMessage = "Proszę podać numer telefonu.")]
        [Phone(ErrorMessage = "Numer telefonu jest niepoprawny.")]
        public string Phone{ get; set; }
        [Required(ErrorMessage = "Określ swoją obecność na imprezie.")]
        public bool? WillAttend{ get; set; }
        //[Range(typeof(bool), "true", "true", ErrorMessage = "Określ swój stosunek do potraw.")]
        public bool BeVegetarianOrNot{ get; set; }
    }
}