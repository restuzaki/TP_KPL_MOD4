using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_103022300029
{
    enum State { TERBUKA, TERKUNCI };

    class DoorMachine
    {
        State state = State.TERKUNCI;

        public void reaksi()
        {
            if (state == State.TERKUNCI)
            {
                Console.WriteLine("Pintu terkunci");
            }
            else if (state == State.TERBUKA)
            {
                Console.WriteLine("Pintu terbuka");
            }
        }

        public void putarKunci()
        {
            if (state == State.TERKUNCI)
            {
                state = State.TERBUKA;
            }
            else if (state == State.TERBUKA)
            {
                state = State.TERKUNCI;
            }
        }
    }
}
