//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace МСЧ52
{
    using System;
    using System.Collections.Generic;
    
    public partial class Diagnosis
    {
        public int Id { get; set; }
        public int IdPastients { get; set; }
        public string Name { get; set; }
    
        public virtual Pastients Pastients { get; set; }
    }
}
