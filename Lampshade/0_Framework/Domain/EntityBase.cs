using System;

namespace _0_Framework.Domain
{
    public class EntityBase
    {
        public long Id { get; set; }
        public DateTime CreationDate { get; set; }

        public EntityBase()
        {
            CreationDate = DateTime.Now;
        }
    }
}
