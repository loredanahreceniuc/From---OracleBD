using LibrarieModele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NivelAccesDate
{
   public interface IStocareJucator : IStocareFactory
    {
        List<Jucator> GetJucatori();

        Jucator GetJucator(int id);

        bool AddJucator(Jucator j);

        bool DeleteJucator(int id);

        Jucator getCelMaiTanarJucator();
    }
}
