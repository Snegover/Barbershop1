//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Barbershop.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Administrator
    {
        public Administrator()
        {
            this.Entry = new HashSet<Entry>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Middlename { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    
        public virtual ICollection<Entry> Entry { get; set; }
    }
}