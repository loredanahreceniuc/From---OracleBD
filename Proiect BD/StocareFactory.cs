using NivelAccesDate;
using System;
using System.Collections.Generic;
using System.Configuration;
using LibrarieModele;

namespace Proiect_BD
{
    /// <summary>
    /// Factory Design Pattern
    /// </summary>
    public class StocareFactory
    {
        public IStocareFactory GetTipStocare(Type tipEntitate)
        {
            var formatSalvare = ConfigurationManager.AppSettings["FormatSalvare"];
            if (formatSalvare != null)
            {
                switch (formatSalvare)
                {
                    default:
                    case "BazaDateOracle":

                        if (tipEntitate == typeof(Echipa))
                        {
                            return new AdministrareEchipa();
                        }
                        if (tipEntitate == typeof(Clasament))
                        {
                            return new AdministrareClasament();
                        }
                        if(tipEntitate == typeof(Jucator))
                        {
                            return new AdministrareJucator();
                        }
                        if(tipEntitate == typeof(Meci))
                        {
                            return new AdministrareMeci();
                        }
                        break;
                    case "BIN":
                        //instantiere clase care realizeaza salvarea in fisier binar
                        break;
                }
            }
            return null;
        }
    }
}
