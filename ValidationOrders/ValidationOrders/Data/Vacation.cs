using System.ComponentModel.DataAnnotations;

namespace ValidationOrders.Data
{
    //отпуск
    public class Vacation
    {
        //код отпуска
        public int Id { get; set; }

        //тип отпуска (основной оплачиваемый, ежегодный дополнительный, учебный, без сохранения заработной платы, по уходу за ребенком и отпуск по беременности и родам и т.д.)
        [Required(ErrorMessage = "Поле обязательно для заполнения.")]
        public string? Type { get; set; }

        //оплата отпуска
        [Required(ErrorMessage = "Поле обязательно для заполнения.")]
        public string? Payment { get; set;}

        //льготы по отпуску (да/нет)
        [Required(ErrorMessage = "Поле обязательно для заполнения.")]
        public string? Benefit { get; set;}

        //связи
        public virtual ICollection<Document>? Documents { get; set; }

    }
}
