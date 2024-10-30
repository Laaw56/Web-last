using System.ComponentModel.DataAnnotations;

namespace ValidationOrders.Data
{
    //сотрудник
    public class Employee
    {
        //код сотрудника
        public int Id { get; set; }

        //фамилия
        [Required(ErrorMessage = "Поле обязательно для заполнения.")]
        public string? LastName { get; set; }

        //имя
        [Required(ErrorMessage = "Поле обязательно для заполнения.")]
        public string? FirstName { get; set; }

        //отчество
        [Required(ErrorMessage = "Поле обязательно для заполнения.")]
        public string? MiddleName { get; set; }

        //должность
        [Required(ErrorMessage = "Поле обязательно для заполнения.")]
        public string? Position { get; set; }

        //подразделение
        [Required(ErrorMessage = "Поле обязательно для заполнения.")]
        public string? Division { get; set; }

        //дата приема на работу
        [Required(ErrorMessage = "Поле обязательно для заполнения.")]
        public DateOnly EmploymentDate { get; set; }

        //связи
        public IEnumerable<Document>? Documents { get; set; }
    }
}
