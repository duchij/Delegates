using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Stroj
    {
        private string nazevStroja;

        private Teplomer teplomer
        {
            get;set;
        }


        public Stroj(string nazevStroja)
        {

            this.teplomer = new Teplomer();
            this.nazevStroja = nazevStroja;

            this.teplomer.prehratie += onPrehratieStroja;
        }

        private void onPrehratieStroja(int teplota)
        {

            Console.WriteLine("Prehratie....{0}",teplota);

            this.vypniStroj();
        }

        public void zapniStroj()
        {
            Console.WriteLine("Zapinam {0}",this.nazevStroja);
        }

        public void vypniStroj()
        {
            Console.WriteLine("Vypinam {0}",this.nazevStroja);
        }

       

    }
}
