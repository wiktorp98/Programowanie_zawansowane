using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    class ChangeWindow
    {
        Form formToOpen;
        Thread thread;
        public ChangeWindow(Form formToClose,Form formToOpen) {
            this.formToOpen = formToOpen;
            formToClose.Close();
            thread = new Thread(change);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void change(object obj) {
            Application.Run(formToOpen);
        }
    }
}
