using System.ComponentModel.DataAnnotations;

namespace EmpresteFacil.Models
{
    public class Installment
    {
        [Key]
        public int Id { get; set; }
        public DateTime DueDate { get; set; }
    }
}
