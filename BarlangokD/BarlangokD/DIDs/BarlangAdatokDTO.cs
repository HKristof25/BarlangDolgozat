using System.ComponentModel.DataAnnotations;

namespace BarlangokD.DIDs
{
    public class BarlangAdatokDTO
    {
        [Key]
        public string Telepules { get; set; }

        public int BarlangokSzama { get; set; }

    }
}
