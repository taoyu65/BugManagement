using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BugManagement.Core.Tools
{
    [Serializable]
    public abstract class Entity
    {
        ///// <summary>
        ///// If ban the logic delete (not the physical delete)
        ///// </summary>
        //public bool IsDeleted { get; set; }

        ///// <summary>
        ///// Add date time
        ///// </summary>
        //[DataType(DataType.DateTime)]
        //public DateTime AddDate { get; set; }

        ///// <summary>
        ///// Timestamp
        ///// </summary>
        //[ConcurrencyCheck]
        //[Timestamp]
        //public byte[] Timestamp { get; set; }

        //protected Entity()
        //{
        //    IsDeleted = false;
        //    AddDate = DateTime.Now;
        //}
    }
}
