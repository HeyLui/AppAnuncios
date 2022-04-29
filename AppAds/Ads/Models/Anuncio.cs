using System;
using System.Collections.Generic;

#nullable disable

namespace Ads.Models
{
    public partial class Anuncio
    {
        public Anuncio()
        {
            PuntajeUserAds = new HashSet<PuntajeUserAd>();
        }

        public int IdAd { get; set; }
        public string NombreAd { get; set; }
        public string Descripcion { get; set; }
        public byte[] Imagen { get; set; }
        public int? IdTipoad { get; set; }
        public int? Calificacion { get; set; }

        public virtual CategoriaAd IdTipoadNavigation { get; set; }
        public virtual ICollection<PuntajeUserAd> PuntajeUserAds { get; set; }
    }
}
