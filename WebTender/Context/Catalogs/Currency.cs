using System.ComponentModel.DataAnnotations;

namespace WebTender.Context.Catalogs
{
    public enum Currency
    {
        [Display(Name = "Гривна")]
        Hryvnia = 1,

        [Display(Name = "Евро")]
        Euro,

        [Display(Name = "Доллар")]
        Dolar
    }
}