using LibrarieModele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NivelAccesDate
{
    public interface IStocareEchipa : IStocareFactory
    {
        List<Echipa> GetEchipe();
        Echipa GetEchipa(int id);
        bool AddEchipa(Echipa d);
        bool UpdateEchipa(Echipa d);
    }
}
