using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankApp.Models.Models.Common
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OtherName { get; set; }
        private DateTime CreatedDate { get; set; }
        private string CreatedBy { get; set; }
        private DateTime ModifiedDate { get; set; }
        private string ModifiedBy { get; set; }
    }
}
