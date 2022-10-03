using System.ComponentModel.DataAnnotations;

namespace EmpresteFacil.Models
{
    public class LoanRequest: BaseModel
    {
        public DateTime? ApprovedAt { get; set; }
        public decimal Value { get; set; }
    }
}
