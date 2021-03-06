﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aspMvcExercise.Models
{
    [Table("Kategorija")]
    public partial class Kategorija
    {
        public Kategorija()
        {
            Proizvodi = new HashSet<Proizvod>();
        }

        [Key]
        public int KategorijaId { get; set; }

        [Required(ErrorMessage = "Unesi naziv")]
        [StringLength(50, ErrorMessage = "Maksimalno 50 karaktera")]
        [Display(Name = "Naziv")]
        public string NazivKategorije { get; set; }

        [Required(ErrorMessage = "Unesi opis")]
        [StringLength(100, ErrorMessage = "Maksimalno 100 karaktera")]
        [Display(Name = "Opis")]
        public string OpisKategorije { get; set; }

        [InverseProperty("Kategorija")]
        public virtual ICollection<Proizvod> Proizvodi { get; set; }
    }
}