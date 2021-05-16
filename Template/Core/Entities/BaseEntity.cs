using $safeprojectname$.Enums;
using Dapper.Contrib.Extensions;
using System;

namespace $safeprojectname$.Entities
{
    public class BaseEntity
    {
        [ExplicitKey]
        public int Id { get; set; }
        public DateTime CreationDate { get; init; }
        public DateTime? ModifiedDate { get; set; }
        public int CreatorId { get; set; }
        public enumRecordStatus Status { get; set; }

        public BaseEntity()
        {
            CreationDate = DateTime.Now;
            Status = enumRecordStatus.Active;
        }
    }
}
