using EFEntities.Abstract;

namespace EFEntities.Concrete
{
    public class Worker : IEntity
    {
        public int WorkerId { get; set; }
        public string WorkerName { get; set; }
        public string WorkerLastName { get; set; }
        public string WorkerEmail { get; set; }
        public string WorkerUsername { get; set; }
        public string WorkerPassword { get; set; }
        public decimal WorkerSalary { get; set; }
    }
}