using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ResourcesProject.Models
{

    public enum GenreEnum
    {
        [Display(Name = "Heavy Metal")]
        HeavyMetal,
        Rock,
        [Display(Name = "Death Metal")]
        DeathMetal,
        Blues,
        Jazz
    }

    public class MusicBand
    {
        public string Name { get; set; }
        public GenreEnum Genre { get; set; }
    }
}