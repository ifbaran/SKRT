using EFEntities.Abstract;

namespace EFEntities.Concrete
{
    public class Chair : IEntity
    {
        public int ChairId { get; set; }
        public string ChairName { get; set; }
        public bool ChairStatus { get; set; }
    }
}