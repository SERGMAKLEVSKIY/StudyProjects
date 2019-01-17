using System.ComponentModel.DataAnnotations;

namespace WebTender.Context.Catalogs
{
    public enum TenderType
    {
        [Display(Name = "Открытые торги")]
        OpenTorgues = 1,

        [Display(Name = "Закрытые торги")]
        ClosedTorgues,

        [Display(Name = " Анализ цен")]
        EvaluationPrice
    }
}