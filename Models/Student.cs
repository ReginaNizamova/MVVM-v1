//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ControlStudy.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            this.GradesStudents = new HashSet<GradesStudent>();
        }
    
        public int IdStudent { get; set; }
        public string Family { get; set; }
        public string Name { get; set; }
        public string Patronimic { get; set; }
        public int IdGroup { get; set; }
        public int IdRole { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GradesStudent> GradesStudents { get; set; }
        public virtual Group Group { get; set; }
        public virtual Role Role { get; set; }
    }
}
