using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Delegates
{
    class Teplomer
    {
        public delegate void prehratieHandler(int teplota);
        public event prehratieHandler prehratie;

        private Timer timer;

        private Random rnd;
        
        public Teplomer()
        {
            this.rnd = new Random();
            this.timer = new Timer(rnd.Next(2000,4000));
            this.timer.Start();
           
            this.timer.Elapsed += onFire;
        }

        public void onFire(object sender, ElapsedEventArgs arg)
        {
            //timer.Stop();
            timer.Elapsed -= onFire;
            if (prehratie != null) prehratie(100);
        }

    }
}
