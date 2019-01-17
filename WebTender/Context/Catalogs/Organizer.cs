using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebTender.Context.Catalogs
{
    public enum Organizer
    {
        [Display(Name = "Киевский метрополитен")]
        KievUndeground = 1,

        [Display(Name = "Энергоатом")]
        Atom,

       [Display(Name = " Укрзализныця")]
        Railway,

       [Display(Name = "Укрэнерго")]
        Energy
    }
}