using System.ComponentModel.DataAnnotations;

namespace ValidationOrders.Data
{
    //документ
    public class Document
    {
        //код документа
        public int Id { get; set; }

        //номер документа
        [Required(ErrorMessage = "Поле обязательно для заполнения.")]
        public string? Number { get; set; }

        //дата регистрации
        [Required(ErrorMessage = "Поле обязательно для заполнения.")]
        public DateOnly RegistrationDate { get; set; }

        //дата начала отпуска
        [Required(ErrorMessage = "Поле обязательно для заполнения.")]
        public DateOnly VacationStartDate { get; set; }

        //дата окончания отпуска
        [Required(ErrorMessage = "Поле обязательно для заполнения.")]
        public DateOnly VacationEndDate { get; set; }

        //код сотрудника
        [Required(ErrorMessage = "Поле обязательно для заполнения.")]
        public int EmployeeId { get; set; }

        //код отпуска
        [Required(ErrorMessage = "Поле обязательно для заполнения.")]
        public int VacationId { get; set; }

        //связи
        public Employee? Employee { get; set; }

        public Vacation? Vacation { get; set; }
    }
}
