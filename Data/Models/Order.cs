using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace MyShop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int Id { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Поле должно содержать от 3 символов")]
        [Display(Name = "Имя")]
        public string Name { get; set; }

        [Display(Name = "Введите Фамилию")]
        [StringLength(15, MinimumLength = 3,ErrorMessage = "Поле должно быть установлено")]
        [Required(ErrorMessage = "Поле должно содержать от 3 символов")]
        public string SurName { get; set; }

        [Display(Name = "Адрес")]
        [StringLength(20,MinimumLength = 3, ErrorMessage = "Поле должно быть установлено")]
        [Required(ErrorMessage = "Поле должно содержать от 3 символов")]
        public string Adress { get; set; }

        [Display(Name = "Номер телефона")]
        [StringLength(11, MinimumLength = 3, ErrorMessage = "Поле должно быть установлено")]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Поле должно содержать от 3 символов")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Поле должно содержать от 3 символов")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Поле должно содержать от 3 символов")]
        public string Email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderTime { get; set; }
        public List<OrderDetail> orderDetails { get; set; }

    }
}
