using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Models;

namespace BLL.Models
{
    public class SaloonManager
    {
        private SK4RTContext context;
        public SaloonManager()
        {
            context = new SK4RTContext();
        }

        public bool AddSaloon(string saloonName)
        {
            if (saloonName != string.Empty)
            {
                Saloons saloon = new Saloons
                {
                    SaloonName = saloonName
                };
                context.Saloons.Add(saloon);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateSaloon(int saloonId, string saloonName)
        {
            List<Saloons> saloon = context.Saloons.Where(x => x.SaloonId == saloonId).ToList();
            if (saloonId != null)
            {
                saloon[0].SaloonName = saloonName;
                context.Saloons.Update(saloon[0]);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteSaloon(int id)
        {
            List<Saloons> saloon = context.Saloons.Where(x => x.SaloonId == id).ToList();
            if (id != null)
            {
                context.Saloons.Remove(saloon[0]);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<string> GetSaloons()
        {
            return context.Saloons.Select(x => x.SaloonName).ToList();
        }

        public List<Saloons> SaloonDGW()
        {
            return context.Saloons.ToList();
        }
    }
}
