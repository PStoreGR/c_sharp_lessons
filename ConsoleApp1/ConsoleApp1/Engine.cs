using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Engine
    {
        private bool hasfuell;
        Car car;
        public bool HasFuell
        {
            get { return hasfuell; }
            set { hasfuell = value; }
        }

        public Engine()
        {
            
        }

        public bool checFuell()
        {
            if (car.Fuell > 15)
            {
                car.engine.hasfuell = true;
                return true;
            }
            else
            {
                car.engine.hasfuell = false;
                return false;
            }
        }
    }
}
