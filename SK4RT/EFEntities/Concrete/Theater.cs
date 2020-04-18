using EFEntities.Abstract;

namespace EFEntities.Concrete
{
    public class Theater:IEntity
    {
        public int TheaterId { get; set; }
        public string TheaterName { get; set; }
        public string TheaterAuthor { get; set; }
        public int TheaterPeriod { get; set; }
    }
}