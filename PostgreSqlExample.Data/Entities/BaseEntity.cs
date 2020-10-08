using System;
using System.Collections.Generic;
using System.Text;

namespace PostgreSqlExample.Data.Entities
{
    /// <summary>
    /// Tüm entity modellerimizde kalıtım yoluyla kullanılır. Abstract  yaparak new() ile oluşturulması engellenir.
    /// </summary>
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        /// <summary>
        /// Default değer atamak için {}= deger olarak kullanılır.
        /// </summary>
        public bool IsActive { get; set; } = true;

        public DateTime CreatedTime { get; set; } = DateTime.Now;

        /// <summary>
        /// "?" database tarafında nullable alan oluşturur
        /// </summary>
        public DateTime? UpdatedTime { get; set; }
    }
}