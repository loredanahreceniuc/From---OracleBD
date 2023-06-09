using LibrarieModele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace NivelAccesDate
{
    public interface IStocareClasament : IStocareFactory
    {
        List<Clasament> GetClasamente();
        Clasament GetClasament(int id);
        bool UpdateClasament(Clasament d);
        int GetClasamentEchipaGolaveraj();
    }
}
