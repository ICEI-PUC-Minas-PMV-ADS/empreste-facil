using System.ComponentModel.DataAnnotations;

namespace EmpresteFacil.Models
{
    public class Installment : BaseModel
    {
        public Guid LoanId{ get; set; }
        public DateTime DueDate { get; set; }
    }
}
