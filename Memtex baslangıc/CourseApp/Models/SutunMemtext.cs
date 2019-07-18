using System.ComponentModel.DataAnnotations;

namespace CourseApp.Models
{
    public class SutunMemtext
    {
        [Required(ErrorMessage = "Talep Geliş Tarihini giriniz.")]   public string TalepGelisTarihi { get; set; }    //??????????
        [Required(ErrorMessage = "Temrin tarihini giriniz")]   public string Temrin { get; set; }         //????????
        [Required(ErrorMessage = "Artikel giriniz.")]   public string Artikel { get; set; }
        [Required(ErrorMessage = "Müşteri Model Numarasını giriniz.")]  public string MusteriModelNumarasi { get; set; }
        [Required(ErrorMessage = "Beden giriniz.")]   public string Beden { get; set; }  
        [Required(ErrorMessage = "Renk giriniz.")]   public string Renk { get; set; }  
        [Required(ErrorMessage = "Numune Tipi giriniz.")]   public string NumuneTipi { get; set; }  
        [Required(ErrorMessage = "Modelist ve argeci giriniz.")]   public string ModelistVeArgeci { get; set; }  
        public string ModelAciklamasi { get; set; }  
        public string AksesuarSiparisTarihi { get; set; }  
        public string AksesuarTemrin { get; set; }  
        public string OrguBitisTarihi { get; set; }  
        public string PlanlananBoyaGonderim { get; set; }  
        public string BoyadanGelis { get; set; }  
        public string DikimBitis { get; set; }  
        public string SonDurum { get; set; }   
        public string TeslimTarihi { get; set; }
        public string GecikmeAciklama { get; set; }  
        public string TeslimSuresi { get; set; }  //otomatik hesaplansın (temrin-geliş)= 
 
    }
}