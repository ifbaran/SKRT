using EFEntities.Abstract;

namespace EFEntities.Concrete
{
    public class Film:IEntity
    {
        public int FilmId { get; set; }
        public string FilmName { get; set; }
        public string FilmAuthor { get; set; }
        public int FilmPeriod { get; set; }
    }
}