using LibrarieModele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NivelAccesDate
{
    public interface IStocareMeci : IStocareFactory
    {
        List<Meci> getMeciuri();
        Meci getMeci(int id);

        Meci getMeciDintre(int idA, int idB);


    }
}
