using DAL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class ReporteBOL
    {
        private ReporteDAL Dal()
        {
            return new ReporteDAL();
        }

        public int[] porcentajeOcupacion()
        {
            LinkedList<int> po = Dal().porcentajeOcupacion();
            int[] pr = new int[po.Count()];
            for (int i = 0; i < po.Count; i++)
            {
                pr[i] = po.ElementAt(i);
            }
            return pr;

        }
        public string[] Ocupacion()
        {
            LinkedList<string> po = Dal().Ocupacion();
            string[] pr = new string[po.Count()];
            for (int i = 0; i < po.Count; i++)
            {
                pr[i] = po.ElementAt(i);
            }
            return pr;
        }

    }
}
