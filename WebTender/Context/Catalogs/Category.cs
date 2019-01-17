using System.ComponentModel.DataAnnotations;

namespace WebTender.Context.Catalogs
{
    public enum Category 
    {
        [Display(Name = "Химическая продукция")]
        ChemicalProducts = 1,

        [Display(Name = "Одежда,обувь,сумки и аксессуары,")]
        ClothingShoesFootwearAccessories,

        [Display(Name = "Нефтепродукты,топливо,электроэнергия,")]
        PetroleumProductsOilElectricity,

        [Display(Name = "Печатная продукция")]
        PrintedProducts
    }
}