using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common_Objects_V2.Intake.Models
{
    [Table("apl_User")]
    public class User
    {
        public User()
        {
            //this.apl_User_Role_Delegation = new HashSet<apl_User_Role_Delegation>();
            //this.apl_User_Role_Delegation1 = new HashSet<apl_User_Role_Delegation>();
            //this.apl_User_Image = new HashSet<apl_User_Image>();
            this.Groups = new HashSet<Group>();
            //this.Roles = new HashSet<Role>();
            this.UserRoles = new HashSet<UserRole>();
            
        }
        [Key]
        public int User_Id { get; set; }
        public string? First_Name { get; set; }
        public string? Last_Name { get; set; }
        public string? Initials { get; set; }
        public string? Email_Address { get; set; }
        public string? User_Name { get; set; }
        public string? Password { get; set; }
        public DateTime? Date_Last_Login { get; set; }
        public DateTime? Date_Created { get; set; } = DateTime.Now;
        public string? Created_By { get; set; }
        public DateTime? Date_Last_Modified { get; set; }
        public string? Modified_By { get; set; }
        public bool Is_Active { get; set; } = true;
        public bool Is_Deleted { get; set; } = false;
        public string? AccountStatus { get; set; }
        public int? Tries { get; set; } = 0;
        public DateTime? PasswordExpiryDate { get; set; } = DateTime.Now.AddMonths(12);
        public string? FirstTimeLogin { get; set; } = "Yes";
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<apl_User_Role_Delegation> apl_User_Role_Delegation { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<apl_User_Role_Delegation> apl_User_Role_Delegation1 { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<apl_User_Image> apl_User_Image { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Group> Groups { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Role> Roles { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
        
    }
}
