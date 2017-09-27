using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using BilletLibrary;

namespace WCFBilletServiceNEW
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Billetten" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Billetten.svc or Billetten.svc.cs at the Solution Explorer and start debugging.
    public class Billetten : IBilletten
    {
        public int BilPris()
        {
            var billetpris = new Bil();

            return billetpris.Pris();
        }

        public int BilPrisMedBrobizz()
        {
            var billetpris = new Bil();

            billetpris.BroBizz = true;
            return billetpris.Pris();
        }

        public int BilPrisØresund()
        {
            var billet = new BilØreSund();
            return billet.Pris();
        }

       

        public int BilPrisØresundMedBroBizz()
        {
            var billet = new BilØreSund();
            billet.BroBizz = true;
            return billet.Pris();
        }


        public int McPris()
        {
            var billet = new MC();
            return billet.Pris();
        }

        public int McPrisMedBrobizz()
        {
            var billet = new MC();
            billet.BroBizz = true;
            return billet.Pris();
        }

        public int McPrisMedØresund()
        {
            var billet = new MCØresund();
            return billet.Pris();
        }

        public int McPrisØresundMedBroBizz()
        {
            var billet = new MCØresund();
            billet.BroBizz = true;
            return billet.Pris();
        }
    }
}
