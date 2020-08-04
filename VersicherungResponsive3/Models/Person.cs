using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VersicherungResponsive3.Models
{
    public class Person
    {
     
            [Required(ErrorMessage = "*Es fehlt Benutzername")]
            [Display(Name = "Gewünschter Benutzername")]
            [DataType(DataType.Text)]
            public string Benutzername { get; set; }

            [Required(ErrorMessage = "*Es fehlt der Passwort")]
            [Display(Name = "Passwort")]
            [DataType(DataType.Text)]
            public string Passwort { get; set; }


            [Required(ErrorMessage = "*Es ist ungleich")]
            [Display(Name = "Passwort wiederholen")]
            [DataType(DataType.Text)]
            [Compare("Passwort")]
            public string Passwordwiederholen { get; set; }


            [Required(ErrorMessage = "*Es fehlt Anrede")]
            [Display(Name = "Anrede")]
            [DataType(DataType.Text)]
            public string Anrede { get; set; }


            [Required(ErrorMessage = "*Es fehlt Vorname")]
            [Display(Name = "Vorname")]
            public string Vorname { get; set; }


            [Required(ErrorMessage = "*Es fehlt Nachname")]
            [Display(Name = "Nachname")]
            [DataType(DataType.Text)]
            public string Nachname { get; set; }


            [Required(ErrorMessage = "*Es fehlt Email")]
            [Display(Name = "Email")]
            [DataType(DataType.EmailAddress)]
            public string Email { get; set; }


            [Required(ErrorMessage = "*Es fehlt Email bestaetigen")]
            [Display(Name = "E mail bestätigen")]
            [Compare("Email")]
            public string Emailbestatigen { get; set; }

            [Required(ErrorMessage = "*Es fehlt Mobilfunknummer")]
            [Display(Name = "Mobilfunknummer")]
            public string Mobilfunknummer { get; set; }


            [Required(ErrorMessage = "*Es fehlt Kunde")]
            [Display(Name = "Ich bin bereits Kunde")]
            public string IchBinBereitsKunde { get; set; }

        

    }
}