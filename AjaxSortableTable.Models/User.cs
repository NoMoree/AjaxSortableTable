using System.ComponentModel.DataAnnotations;

namespace AjaxSortableTable.Models
{
    public class User
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        public Sex Sex { get; set; }

        public string Telephone { get; set; }
        
        public virtual UserStatus Status { get; set; }
    }
}
