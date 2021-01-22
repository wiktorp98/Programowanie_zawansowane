using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    interface IDirector
    {

        Person[] showWorkers();

        bool inviteWorker(string email);
        
    }
}
