using System.ComponentModel.DataAnnotations;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class UpdateRoomDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Lütfen Oda Numarasını Giriniz !")]
        public string RoomNumber { get; set; }
        [Required(ErrorMessage = "Lütfen Oda Görseli Giriniz !")]
        public string RoomCoverImage { get; set; }
        [Required(ErrorMessage = "Lütfen Fiyat Bilgisi Giriniz !")] 
        public int Price { get; set; }
        [Required(ErrorMessage = "Lütfen Oda Başlığı Bilgisi Giriniz !")]
        [StringLength(100,ErrorMessage ="Lütfen en fazla 100 karakter girişi yapınız !")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Lütfen Yatak Sayısı  Giriniz !")]
        public string BedCount { get; set; }
        [Required(ErrorMessage = "Lütfen Banyo Sayısı  Giriniz !")]
        public string BathCount { get; set; }
        public string Wifi { get; set; }
        [Required(ErrorMessage = "Lütfen Açıklama Giriniz !")]
        public string Description { get; set; }
    }
}
