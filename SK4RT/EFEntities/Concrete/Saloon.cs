using System;
using EFEntities.Abstract;

namespace EFEntities.Concrete
{
    public class Saloon : IEntity
    {
        public int SessionId { get; set; }
        public DateTime SessionTime { get; set; } // ToShortTimeString() fonksiyonunu kullan.
    }
}