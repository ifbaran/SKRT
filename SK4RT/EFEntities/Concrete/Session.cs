using System;
using EFEntities.Abstract;

namespace EFEntities.Concrete
{
    public class Session :IEntity
    {
        public int SessionId { get; set; }
        public int SaloonId { get; set; }
        public int FilmId { get; set; }
        public int TheaterId { get; set; }
        public DateTime TranDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}