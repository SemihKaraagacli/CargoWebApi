using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace Cargo.Data.Models
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; } = new DateTime();
        public DateTime? LatestDate { get; set; } = new DateTime();

    }
}
