using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Models
{
    public class BaseEntity
    {
        public int Id { get; set; } // Primary Key
        public int CreatedBy { get; set; } //By user id
        public DateTime CreatedOn { get; set; } // The time of creation 
        public int LastModifiedBy { get; set; } //By user id
        public DateTime? LastModifiedOn { get; set; } // The time of last Modification
        public bool IsDeleted { get; set; } // Soft Delete

    }
}
